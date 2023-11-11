using System.Text;

namespace BundleManager
{
    public class BundleComparer
    {
        public BundleComparer(string currentRootDirectory, string previousRootDirectory)
        {
            _currentRootDirectory = currentRootDirectory;
            _previousRootDirectory = previousRootDirectory;
        }

        // Compares new and previous versions checksums to know which files to download and which assets to export
        public List<BundleData> GetNewAssetList(string folderName)
        {
            StringBuilder sb = new StringBuilder();
            List<BundleData> newBundlesList = new List<BundleData>();
            Dictionary<string, BundleData> previousBundleDataDictionary = GetPreviousBundleDataDictionary(folderName);
            using (BinaryReader newBundleReader = new BinaryReader(File.Open(Path.Join(_currentRootDirectory, "Bmdata", "Exported", folderName + "_BundleData.bytes"), FileMode.Open)))
            {
                int newBundlesCount = newBundleReader.ReadInt32();
                for (int i = 0; i < newBundlesCount; i++)
                {
                    BundleData bundleData = new BundleData(newBundleReader);
                    if (_specialBundleNames.Contains(bundleData.Name))
                    {
                        newBundlesList.Add(bundleData);
                        continue;
                    }
                    BundleData? previousBundleData;
                    if (previousBundleDataDictionary.TryGetValue(bundleData.Name, out previousBundleData))  // if the bundle already existed
                    {
                        if (!bundleData.Version.Equals(previousBundleData.Version))  // and its content changed
                        {
                            sb.AppendLine($"\n{bundleData.Name} : Version {previousBundleData.Version} -> {bundleData.Version}");
                            foreach (string asset in bundleData.Assets)
                            {
                                if (!previousBundleData.Assets.Contains(asset))
                                {
                                    sb.AppendLine($"\t{asset}");
                                    if (_allowedAssetExtensions.Contains(Path.GetExtension(asset)))
                                    {
                                        bundleData.NewAssetsList.Add(Path.GetFileName(asset));
                                    }
                                }
                            }
                            if (bundleData.NewAssetsList.Count != 0)
                            {
                                newBundlesList.Add(bundleData);
                            }
                        }
                    }
                    else
                    {
                        sb.AppendLine($"\n{bundleData.Name} : New");
                        foreach (string asset in bundleData.Assets)
                        {
                            if (_allowedAssetExtensions.Contains(Path.GetExtension(asset)))
                            {
                                bundleData.NewAssetsList.Add(Path.GetFileName(asset));
                                sb.AppendLine($"\t{asset}");
                            }
                        }
                        if (bundleData.NewAssetsList.Count != 0)
                        {
                            newBundlesList.Add(bundleData);
                        }
                    }
                }
            }
            if (sb.Length != 0)
            {
                File.WriteAllText($"{_currentRootDirectory}/{folderName}_output.txt", sb.ToString());
            }
            return newBundlesList;
        }

        private Dictionary<string, BundleData> GetPreviousBundleDataDictionary(string folderName)
        {
            Dictionary<string, BundleData> previousBundleDataDictionary = new Dictionary<string, BundleData>();
            BinaryReader previousBundleReader = new BinaryReader(File.Open(Path.Join(_previousRootDirectory, "Bmdata", "Exported", folderName + "_BundleData.bytes"), FileMode.Open));
            int previousBundlesCount = previousBundleReader.ReadInt32();
            for (int i = 0; i < previousBundlesCount; i++)
            {
                BundleData bundleData = new BundleData(previousBundleReader);
                previousBundleDataDictionary.Add(bundleData.Name, bundleData);
            }
            previousBundleReader.Dispose();
            return previousBundleDataDictionary;
        }

        // Get the names list of the archives to download, the assets are packed in zip files
        public List<string> GetBundleNameList(string folderName, List<string> checksumList)
        {
            List<string> bundleNameList = new List<string>();
            using (BinaryReader bundlePackDataReader = new BinaryReader(File.Open(Path.Join(_currentRootDirectory, "Bmdata", "Exported", folderName + "_BundlePackData.bytes"), FileMode.Open)))
            {
                int newBundlesCount = bundlePackDataReader.ReadInt32();
                for (int i = 0; i < newBundlesCount; i++)
                {
                    BundlePackData bundlePackData = new BundlePackData(bundlePackDataReader);
                    foreach (string checksum in bundlePackData.IncludeBundles)
                    {
                        if (checksumList.Contains(checksum))
                        {
                            bundleNameList.Add(bundlePackData.Name);
                            break;
                        }
                    }
                }
            }
            return bundleNameList;
        }

        private readonly string _currentRootDirectory;

        private readonly string _previousRootDirectory;

        /* .png for Texture2D
         * .prefab for Animator
         * .wav for AudioClip
         */

        private readonly string[] _allowedAssetExtensions = { ".png", ".prefab", ".wav" };

        // Bundles that will be downloaded no matter what
        private readonly string[] _specialBundleNames = { "db", "localizestring_japanese" };
    }
}
