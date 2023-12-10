namespace _7dsgcDatamine
{
    public static class BundleUtility
    {
        // Compares new and previous versions checksums to know which files to download and which assets to export
        public static List<BundleData>? CompareBundleData(byte[] bundleDataContent, byte[] previousBundleDataContent)
        {
            Dictionary<string, BundleData> previousBundleDataDictionary = BundleDataToDictionary(previousBundleDataContent);
            //StringBuilder sb = new StringBuilder();
            List<BundleData> newBundlesList = new List<BundleData>();
            using (BinaryReader newBundleReader = new BinaryReader(new MemoryStream(bundleDataContent)))
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
                        if (bundleData.Version != previousBundleData.Version) // and its content changed
                        {
                            //sb.AppendLine($"\n{bundleData.Name} : Version {previousBundleData.Version} -> {bundleData.Version}");
                            foreach (string asset in bundleData.Assets)
                            {
                                if (!previousBundleData.Assets.Contains(asset))
                                {
                                    //sb.AppendLine($"\t{asset}");
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
                    else  // if the bundle is new
                    {
                        //sb.AppendLine($"\n{bundleData.Name} : New");
                        foreach (string asset in bundleData.Assets)
                        {
                            if (_allowedAssetExtensions.Contains(Path.GetExtension(asset)))
                            {
                                bundleData.NewAssetsList.Add(Path.GetFileName(asset));
                                //sb.AppendLine($"\t{asset}");
                            }
                        }
                        if (bundleData.NewAssetsList.Count != 0)
                        {
                            newBundlesList.Add(bundleData);
                        }
                    }
                }
            }
            //if (sb.Length != 0)
            //{
            //    File.WriteAllText($"{baseDirectory}/{section}_output.txt", sb.ToString());
            //}
            return newBundlesList;
        }

        // Reads the bmdata and parses it into a dictionary Checksum->BundleData
        private static Dictionary<string, BundleData> BundleDataToDictionary(byte[] bundleDataContent)
        {
            Dictionary<string, BundleData> previousBundleDataDictionary = new Dictionary<string, BundleData>();
            using (BinaryReader previousBundleReader = new BinaryReader(new MemoryStream(bundleDataContent)))
            {
                int previousBundlesCount = previousBundleReader.ReadInt32();
                for (int i = 0; i < previousBundlesCount; i++)
                {
                    BundleData bundleData = new BundleData(previousBundleReader);
                    previousBundleDataDictionary.Add(bundleData.Name, bundleData);
                }
            }
            return previousBundleDataDictionary;
        }

        public static BundleData? GetBundleDataFromCondition(byte[] bundleDataContent, Predicate<string> condition)
        {
            using (BinaryReader reader = new BinaryReader(new MemoryStream(bundleDataContent)))
            {
                int count = reader.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    BundleData bundle = new BundleData(reader);
                    if (condition(bundle.Name))
                    {
                        return bundle;
                    }
                }
            }
            return null;
        }

        public static string? GetBundlePackName(byte[] bundePackDataContent, string checksum)
        {
            using (BinaryReader bundlePackDataReader = new BinaryReader(new MemoryStream(bundePackDataContent)))
            {
                int newBundlesCount = bundlePackDataReader.ReadInt32();
                for (int i = 0; i < newBundlesCount; i++)
                {
                    BundlePackData bundlePackData = new BundlePackData(bundlePackDataReader);
                    if (bundlePackData.IncludeBundles.Contains(checksum))
                    {
                        return bundlePackData.Name;
                    }
                }
            }
            return null;
        }

        // TODO : Check if all the checksum in checksumList were found
        // Get the names list of the archives to download, the assets are packed in zip files
        public static List<string> GetBundleNameList(byte[] bundlePackDataContent, List<string> checksumList)
        {
            List<string> bundleNameList = new List<string>();
            using (BinaryReader bundlePackDataReader = new BinaryReader(new MemoryStream(bundlePackDataContent)))
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

        /* .png for Texture2D
         * .prefab for Animator
         * .wav for AudioClip
         */

        private static readonly string[] _allowedAssetExtensions = { ".png", ".prefab", ".wav" };

        // Bundles that will be downloaded no matter what
        private static readonly string[] _specialBundleNames = { "db", "localizestring_japanese", "localizestring_korean", "localizestringdb_english" };
    }
}
