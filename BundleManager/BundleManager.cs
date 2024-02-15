using ServiceStack;
using System.IO.Compression;
using System.Text;

namespace _7dsgcDatamine
{
    public class BundleManager
    {
        public BundleManager(GameCode gameCode, BundleDownloader downloader, BundleDecryptor decryptor, string currentBaseDirectorystring, string? previousBaseDirectory)
        {
            switch (gameCode)
            {
                case GameCode.nanatsunotaizai:
                    _localizationFileName = "LocalizeString_Japanese.bytes";
                    _sections = new Section[] { Section.m, Section.b, Section.s, Section.w, Section.jal, Section.jas, Section.jau };
                    break;
                case GameCode.nanakr:
                    _localizationFileName = "LocalizeString_Korean.bytes";
                    _sections = new Section[] { Section.m, Section.b, Section.s, Section.w, Section.kol, Section.kos, Section.kou };
                    break;
                case GameCode.nanagb:
                    _localizationFileName = "LocalizeString_English.bytes";
                    _sections = new Section[] { Section.m, Section.b, Section.s, Section.w, Section.enl, Section.jas, Section.enu };
                    break;
                default:
                    throw new Exception($"Invalid game code.");
            }
            _bundleDownloader = downloader;
            _bundleDecryptor = decryptor;

            // I don't like that but I can't think of a better way
            _bmdataDirectory = Path.Combine(currentBaseDirectorystring, BmdataFolder);
            _bundleDirectory = Path.Combine(currentBaseDirectorystring, BundleFolder);
            _exportDirectory = Path.Combine(currentBaseDirectorystring, ExportFolder);
            _databaseDirectory = Path.Combine(_exportDirectory, AssetExporter.DatabaseFolder);
            _localizationDirectory = Path.Combine(_exportDirectory, AssetExporter.LocalizationFolder);
            _localizationPath = Path.Combine(_localizationDirectory, _localizationFileName);

            if (previousBaseDirectory is not null)
            {
                _previousBmdataDirectory = Path.Combine(previousBaseDirectory, BmdataFolder);
                _previousLocalizationPath = Path.Combine(previousBaseDirectory, ExportFolder, AssetExporter.LocalizationFolder, _localizationFileName);
            }
        }

        private void CreateDirectories()
        {
            Directory.CreateDirectory(_bmdataDirectory);
            Directory.CreateDirectory(_bundleDirectory);
            Directory.CreateDirectory(_exportDirectory);
            // _databaseDirectory and _localizationDirectory are useless because they are already created by AssetExporter.CreateExportDirectory(string baseDirectory)
            Directory.CreateDirectory(_databaseDirectory);
            Directory.CreateDirectory(_localizationDirectory);

        }

        public void DownloadNew()
        {
            if (_previousBmdataDirectory is null)
            {
                Console.WriteLine("The directory where the files to compare with are located doesn't exist.");
                return;
            }
            CreateDirectories();
            Dictionary<Section, List<BundleData>> sectionAssetsDictionary = new Dictionary<Section, List<BundleData>>();
            foreach (Section section in _sections)
            {
                Console.WriteLine($"\nProcessing section {section}...");
                byte[]? bmdata = _bundleDownloader.DownloadBmdataFile(section).Result;
                if (bmdata is null)
                {
                    Console.WriteLine($"Skipping section {section} because the bmdata couldn't be downloaded.");
                    continue;
                }
                Console.WriteLine($"Downloaded {section} bmdata");
                File.WriteAllBytes(Path.Combine(_bmdataDirectory, section.ToString()), _bundleDecryptor.Decrypt(bmdata));
                byte[]? bundleData, bundlePackData;
                AssetExporter.ExportBmdataFile(_bmdataDirectory, section, out bundleData, out bundlePackData);
                string previousBundleDataPath = Path.Combine(_previousBmdataDirectory, $"{section}_BundleData.bytes");
                if (bundleData is null || bundlePackData is null || !File.Exists(previousBundleDataPath))
                {
                    Console.WriteLine($"Skipping section {section} because its bmdata content couldn't be exported, or because the previous bundle data file doesn't exist.");
                    continue;
                }
                List<BundleData>? newBundles = BundleUtility.CompareBundleData(bundleData, File.ReadAllBytes(previousBundleDataPath));
                if (newBundles is null || newBundles.Count == 0)
                    continue;
                sectionAssetsDictionary.Add(section, newBundles);
                List<string> bundlePackNameList = BundleUtility.GetBundleNameList(bundlePackData, newBundles.Select(bd => bd.Checksum).ToList());
                foreach (string bundleName in bundlePackNameList)
                {
                    byte[]? pack = _bundleDownloader.DownloadBundlePackFile(section, bundleName).Result;
                    if (pack is not null)
                    {
                        UnpackBundlePack(pack, newBundles, Path.Combine(_bundleDirectory, section.ToString()));
                        Console.WriteLine($"Downloaded and unpacked archive {bundleName}.zip");
                    }
                }
            }
            Console.WriteLine("\nExporting assets...");
            AssetExporter.CreateExportDirectory(_exportDirectory);
            bool compareLocalization = false, transformDatabase = false;
            // Probably better to export the assets after unpacking the bundles, in the Section loop
            foreach (var item in sectionAssetsDictionary)
            {
                if (item.Key == Section.jal || item.Key == Section.kol || item.Key == Section.enl)
                    compareLocalization = true;
                if (item.Key == Section.b)
                    transformDatabase = true;
                AssetExporter.ExportSectionsAssets(_bundleDirectory, _exportDirectory, item.Key, item.Value);
            }
            if (_previousLocalizationPath is null)
            {
                Console.WriteLine("Can't compare the localizations because the previous localization path doesn't exist.");
            }
            else if (compareLocalization && Localization.Localizer.Load(_localizationPath, _previousLocalizationPath))
            {
                Localization.Localizer.WriteNewStringsToFile(_localizationDirectory);
            }
            if (transformDatabase)
            {
                DatabaseManager.TransformDatabase(_databaseDirectory);
            }
        }

        // Downloads only the mandatory files to be used next time
        public void DownloadBase()
        {
            CreateDirectories();
            foreach (Section section in _sections)
            {
                Console.WriteLine($"\nProcessing section {section}...");
                byte[]? bmdata = _bundleDownloader.DownloadBmdataFile(section).Result;
                if (bmdata is null)
                {
                    Console.WriteLine($"Skipping section {section} because the bmdata couldn't be downloaded.");
                    continue;
                }
                Console.WriteLine($"Downloaded {section} bmdata");
                File.WriteAllBytes(Path.Combine(_bmdataDirectory, section.ToString()), _bundleDecryptor.Decrypt(bmdata));
                byte[]? bundleData, bundlePackData;
                AssetExporter.ExportBmdataFile(_bmdataDirectory, section, out bundleData, out bundlePackData);
                if (bundleData is null || bundlePackData is null)
                {
                    Console.WriteLine($"Skipping section {section} because its bmdata couldn't be exported.");
                    continue;
                }
                if (section == Section.jal || section == Section.kol || section == Section.enl)  // If it's the localization folder
                {
                    BundleData? localizationBundle = BundleUtility.GetBundleDataFromCondition(bundleData, (string s) => s.StartsWith("localizestring"));
                    if (localizationBundle is null)
                    {
                        Console.WriteLine("Couldn't find the localization bundle.");
                        continue;
                    }
                    string? bundlePackName = BundleUtility.GetBundlePackName(bundlePackData, localizationBundle.Checksum);
                    if (bundlePackName is null)
                    {
                        Console.WriteLine("Couldn't find the localization bundle pack");
                        continue;
                    }
                    byte[]? pack = _bundleDownloader.DownloadBundlePackFile(section, bundlePackName).Result;
                    if (pack is not null)
                    {
                        UnpackBundlePack(pack, new List<BundleData> { localizationBundle }, Path.Combine(_bundleDirectory, section.ToString()));
                        Console.WriteLine($"Downloaded and unpacked archive {bundlePackName}.zip");
                        Console.WriteLine("\nExporting localization...");
                        AssetExporter.ExportSectionsAssets(_bundleDirectory, _exportDirectory, section, new List<BundleData> { localizationBundle });
                    }
                }
            }
        }

        private void UnpackBundlePack(byte[] bundlePack, List<BundleData> bundleList, string extractPath)
        {
            Directory.CreateDirectory(extractPath);
            using (MemoryStream responseBody = new MemoryStream(bundlePack))
            {
                using (ZipArchive zip = new ZipArchive(responseBody))
                {
                    foreach (var entry in zip.Entries)
                    {
                        BundleData? bundle = bundleList.Find(bd => bd.Checksum == entry.Name);
                        if (bundle is not null)
                        {
                            using (Stream unzipped = entry.Open())
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    unzipped.CopyTo(ms);
                                    byte[] bundleContent = ms.ToArray();
                                    if (bundle.Encrypt)
                                    {
                                        bundleContent = _bundleDecryptor.Decrypt(bundleContent);
                                    }
                                    File.WriteAllBytes(Path.Combine(extractPath, bundle.Checksum), FixFakeHeader(bundleContent));
                                }
                            }
                        }
                    }
                }
            }
        }

        // The bundles have fake headers that have to be deleted so they can be loaded
        private byte[] FixFakeHeader(byte[] fileContent)
        {
            if (fileContent.Length >= 0x3B && Encoding.UTF8.GetString(fileContent, 0, _fakeHeaderSignature.Length) == _fakeHeaderSignature)
            {
                int bundleSize = BitConverter.ToInt32(fileContent, 0x37);  // The length of the real bundle is stored in the fake header at fileContent[0x37]
                return fileContent[^bundleSize..].ToArray();  // Extract last bundleSize bytes from fileContent
            }
            return fileContent;
        }

        private const string _fakeHeaderSignature = "UnityArchive";

        private readonly string _bmdataDirectory;

        private readonly string _bundleDirectory;

        private readonly string _exportDirectory;

        private readonly string _databaseDirectory;

        private readonly string _localizationDirectory;

        private readonly string _localizationPath;

        private readonly string? _previousBmdataDirectory;

        private readonly string? _previousLocalizationPath;

        private readonly string _localizationFileName;

        private readonly Section[] _sections;

        private readonly BundleDownloader _bundleDownloader;

        private readonly BundleDecryptor _bundleDecryptor;

        // DO NOT CHANGE The folder in which the Bmdata will be saved
        private const string BmdataFolder = "Bmdata";

        // The folder in which the Bundles will be saved
        private const string BundleFolder = "Bundles";

        private const string ExportFolder = "Assets";
    }
}