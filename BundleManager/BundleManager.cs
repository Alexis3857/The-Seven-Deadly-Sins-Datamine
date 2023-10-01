using Decryptor;
using ServiceStack;
using System.Text;

namespace BundleManager
{
    public class BundleManager
    {
        public BundleManager(string patchRelativeSub, string patchVersion, string decryptionKey, string previousDirectoryVersion)
        {
            _currentRootDirectory = Path.Join(Directory.GetCurrentDirectory(), "JP", patchVersion);
            _previousRootDirectory = Path.Join(Directory.GetCurrentDirectory(), "JP", previousDirectoryVersion);
            _bundleDownloader = new BundleDownloader(patchRelativeSub, patchVersion);
            _bundleDecryptor = new BundleDecryptor(decryptionKey);
            _assetExporter = new AssetExporter(_currentRootDirectory);
            _bundleComparer = new BundleComparer(_currentRootDirectory, _previousRootDirectory);
        }

        // Downloads only the mandatory files to be used next time
        public void DownloadBaseOnly()
        {
            Console.WriteLine("\nDownloading bundles...");
            string bmdataDirectory = Path.Join(_currentRootDirectory, "Bmdata");
            if (!Directory.Exists(bmdataDirectory))
            {
                Directory.CreateDirectory(bmdataDirectory);
            }
            if (!Directory.Exists(Path.Join(bmdataDirectory, "Exported")))
            {
                Directory.CreateDirectory(Path.Join(bmdataDirectory, "Exported"));
            }
            foreach (string folder in _folderList)
            {
                byte[] bmdata = _bundleDownloader.DownloadBmdataFile(folder).Result;
                File.WriteAllBytes(Path.Join(bmdataDirectory, folder), _bundleDecryptor.Decrypt(bmdata));
                _assetExporter.ExportBmdataFile(folder);
                if (folder.Equals("jal"))
                {
                    BinaryReader reader = new BinaryReader(File.Open(Path.Join(bmdataDirectory, "Exported", "jal_BundleData.bytes"), FileMode.Open));
                    int count = reader.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        BundleData bundleData = new BundleData(reader);
                        if (bundleData.Name.Equals("localizestring_japanese"))
                        {
                            reader = new BinaryReader(File.Open(Path.Join(bmdataDirectory, "Exported", "jal_BundlePackData.bytes"), FileMode.Open));
                            count = reader.ReadInt32();
                            for (int j = 0; j < count; j++)
                            {
                                BundlePackData bundlePackData = new BundlePackData(reader);
                                if (bundlePackData.IncludeBundles.Contains(bundleData.Checksum))
                                {
                                    _bundleDownloader.DownloadBundlePackFile(folder, new List<string> { bundlePackData.Name }).Wait();
                                    break;
                                }
                            }
                            string localizeFilePath = Path.Join(_currentRootDirectory, "Bundles", folder, bundleData.Checksum);
                            File.WriteAllBytes(localizeFilePath, GetRepairedFile(localizeFilePath));
                            Console.WriteLine("\nExporting localization...");
                            _assetExporter.ExportFolderFiles("jal", new List<BundleData> { bundleData });
                            break;
                        }
                    }
                }
            }
        }

        public void DownloadNew(bool isWriteChangedStrings)
        {
            Console.WriteLine("\nDownloading bundles...");
            string bmdataDirectory = Path.Join(_currentRootDirectory, "Bmdata");
            if (!Directory.Exists(bmdataDirectory))
            {
                Directory.CreateDirectory(bmdataDirectory);
            }
            if (!Directory.Exists(Path.Join(bmdataDirectory, "Exported")))
            {
                Directory.CreateDirectory(Path.Join(bmdataDirectory, "Exported"));
            }
            foreach (string folder in _folderList)
            {
                byte[] bmdata = _bundleDownloader.DownloadBmdataFile(folder).Result;
                File.WriteAllBytes(Path.Join(bmdataDirectory, folder), _bundleDecryptor.Decrypt(bmdata));
                _assetExporter.ExportBmdataFile(folder);
                List<BundleData> assetList = _bundleComparer.GetNewAssetList(folder);
                folderAssetsDictionary.Add(folder, assetList);
                if (assetList.Count != 0)
                {
                    List<string> bundleNameList = _bundleComparer.GetBundleNameList(folder, assetList.Select(bundleData => bundleData.Checksum).ToList());
                    _bundleDownloader.DownloadBundlePackFile(folder, bundleNameList).Wait();
                    string bundleDirectory = Path.Join(_currentRootDirectory, "Bundles", folder);
                    foreach (FileInfo fileInfo in new DirectoryInfo(Path.Join(_currentRootDirectory, "Bundles", folder)).GetFiles())
                    {
                        BundleData? bundleData = assetList.Find((BundleData e) => e.Checksum.Equals(fileInfo.Name));
                        if (bundleData is not null)
                        {
                            if (bundleData.Encrypt)
                            {
                                byte[] decryptedAsset = _bundleDecryptor.Decrypt(File.ReadAllBytes(fileInfo.FullName));
                                File.WriteAllBytes(fileInfo.FullName, decryptedAsset);
                            }
                            else
                            {
                                File.WriteAllBytes(fileInfo.FullName, GetRepairedFile(fileInfo.FullName));
                            }
                        }
                        else
                        {
                            File.Delete(fileInfo.FullName);
                        }
                    }
                }
            }
            Console.WriteLine("\nExporting assets...");
            foreach (string folder in _folderList)
            {
                _assetExporter.ExportFolderFiles(folder, folderAssetsDictionary[folder]);
            }
            Localization.Localizer.Load(_currentRootDirectory, _previousRootDirectory);
            Localization.Localizer.WriteNewStringsToFile(_currentRootDirectory, isWriteChangedStrings);
            DatabaseManager.TransformDatabase(Path.Combine(_currentRootDirectory, "Database"));
        }

        // The assets have fake headers that have to be deleted so they can be loaded
        private byte[] GetRepairedFile(string fileName)
        {
            byte[] fileContent = File.ReadAllBytes(fileName);
            try
            {
                if (Encoding.UTF8.GetString(fileContent, 0, 12).Equals("UnityArchive"))
                {
                    int bundleSize = BitConverter.ToInt32(fileContent, 0x37);
                    return fileContent[^bundleSize..].ToArray();  // Extract last bundleSize bytes from fileContent array
                }
            }
            catch
            {
                Console.WriteLine("Failed to repair " + fileName);
            }
            return fileContent;
        }

        private readonly string _previousRootDirectory;

        private readonly string _currentRootDirectory;

        /* The folders of the game :
         * b = database
         * jal = localization
         * jas = sounds
         * jau = banners images
         * m = models and any other image of the game
         * s = character voices
         * w = weapons models
         */

        private readonly string[] _folderList = { "b", "jal", "jas", "jau", "m", "s", "w" };

        private readonly BundleDownloader _bundleDownloader;

        private readonly BundleDecryptor _bundleDecryptor;

        private readonly BundleComparer _bundleComparer;

        private readonly AssetExporter _assetExporter;

        private Dictionary<string, List<BundleData>> folderAssetsDictionary = new Dictionary<string, List<BundleData>>();
    }
}