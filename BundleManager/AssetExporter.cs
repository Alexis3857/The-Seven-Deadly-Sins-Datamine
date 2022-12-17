using AssetStudio;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace BundleManager
{
    public class AssetExporter
    {
        public AssetExporter(string folder)
        {
            _rootDirectory = folder;
        }

        public void ExportBmdataFile(string folder)
        {
            _assetsManager.LoadFiles(Path.Join(_rootDirectory, "Bmdata", folder));
            foreach (SerializedFile assetFile in _assetsManager.assetsFileList)
            {
                foreach (ObjectInfo obj in assetFile.m_Objects)
                {
                    ObjectReader objectReader = new ObjectReader(assetFile.reader, assetFile, obj);
                    if (objectReader.type == ClassIDType.TextAsset)
                    {
                        TextAsset textAsset = new TextAsset(objectReader);
                        if (textAsset.m_Name.Equals("BundleData") || textAsset.m_Name.Equals("BundlePackData"))
                        {
                            string fileName = $"{folder}_{textAsset.m_Name}.bytes";
                            File.WriteAllBytes(Path.Join(_rootDirectory, "Bmdata", "Exported", fileName), textAsset.m_Script);
                            Console.WriteLine($"Exported {fileName}");
                        }
                    }
                }
            }
            _assetsManager.Clear();
        }

        public void ExportJalFiles()
        {
            string directory = Path.Join(_rootDirectory, "Bundles", "jal");
            string outputDirectory = Path.Join(_rootDirectory, "Localization");
            if (Directory.Exists(directory))
            {
                Directory.CreateDirectory(outputDirectory);
                _assetsManager.LoadFolder(Path.Join(directory));
                foreach (SerializedFile assetFile in _assetsManager.assetsFileList)
                {
                    foreach (ObjectInfo obj in assetFile.m_Objects)
                    {
                        ObjectReader objectReader = new ObjectReader(assetFile.reader, assetFile, obj);
                        if (objectReader.type == ClassIDType.TextAsset)
                        {
                            TextAsset textAsset = new TextAsset(objectReader);
                            if (textAsset.m_Name.StartsWith("LocalizeString_Japanese"))
                            {
                                File.WriteAllBytes(Path.Join(outputDirectory, $"{textAsset.m_Name}.bytes"), textAsset.m_Script);
                                Console.WriteLine($"Exported {textAsset.m_Name}");
                            }
                        }
                    }
                }
                _assetsManager.Clear();
            }
        }

        public void ExportJasFiles(Dictionary<string, BundleData> jasAssetsDictionary)
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "jas");
            string outputDirectory = Path.Join(_rootDirectory, "AudioClip");
            if (jasAssetsDictionary.Count != 0)
            {
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }
                foreach (var item in jasAssetsDictionary)
                {
                    _assetsManager.LoadFiles(Path.Join(assetsDirectory, item.Key));
                    foreach (SerializedFile file in _assetsManager.assetsFileList)
                    {
                        foreach (ObjectInfo obj in file.m_Objects)
                        {
                            ObjectReader objectReader = new ObjectReader(file.reader, file, obj);
                            if (objectReader.type == ClassIDType.AudioClip)
                            {
                                AudioClip audioClip = new AudioClip(objectReader);
                                if (item.Value.Assets.Contains($"{audioClip.m_Name.ToLower()}.wav"))
                                {
                                    AudioClipConverter audioClipConverter = new AudioClipConverter(audioClip);
                                    if (audioClipConverter.IsSupport)
                                    {
                                        byte[] buffer = audioClipConverter.ConvertToWav();
                                        File.WriteAllBytes(Path.Join(outputDirectory, $"{audioClip.m_Name}.wav"), buffer);
                                        Console.WriteLine("Exported " + audioClip.m_Name);
                                    }
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        public void ExportJauFiles(Dictionary<string, BundleData> jauAssetsDictionary)
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "jau");
            string outputDirectory = Path.Join(_rootDirectory, "Texture2D");
            if (jauAssetsDictionary.Count != 0)
            {
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }
                foreach (var item in jauAssetsDictionary)
                {
                    _assetsManager.LoadFiles(Path.Join(assetsDirectory, item.Key));
                    foreach (SerializedFile file in _assetsManager.assetsFileList)
                    {
                        foreach (ObjectInfo obj in file.m_Objects)
                        {
                            ObjectReader objectReader = new ObjectReader(file.reader, file, obj);
                            if (objectReader.type == ClassIDType.Texture2D)
                            {
                                Texture2D texture2D = new Texture2D(objectReader);
                                if (item.Value.Assets.Contains($"{texture2D.m_Name.ToLower()}.png"))
                                {
                                    FileStream fileStream = File.OpenWrite(Path.Join(outputDirectory, $"{texture2D.m_Name}.png"));
                                    Image<Bgra32> image = Texture2DExtensions.ConvertToImage(texture2D, true);
                                    AssetStudio.ImageExtensions.WriteToStream(image, fileStream, ImageFormat.Png);
                                    Console.WriteLine("Exported " + texture2D.m_Name);
                                    fileStream.Close();
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        public void ExportMFiles(Dictionary<string, BundleData> mAssetsDictionary)
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "m");
            string outputDirectoryTexture = Path.Join(_rootDirectory, "Texture2D");
            string outputDirectoryModel = Path.Join(_rootDirectory, "Animator");
            if (mAssetsDictionary.Count != 0)
            {
                if (!Directory.Exists(outputDirectoryTexture))
                {
                    Directory.CreateDirectory(outputDirectoryTexture);
                }
                if (!Directory.Exists(outputDirectoryModel))
                {
                    Directory.CreateDirectory(outputDirectoryModel);
                }
                foreach (var item in mAssetsDictionary)
                {
                    _assetsManager.LoadFiles(Path.Join(assetsDirectory, item.Key));
                    Dictionary<long, string> animatorPathIdDictionary = new Dictionary<long, string>();
                    foreach (SerializedFile file in _assetsManager.assetsFileList)
                    {
                        foreach (ObjectInfo obj in file.m_Objects)
                        {
                            ObjectReader objectReader = new ObjectReader(file.reader, file, obj);
                            if (objectReader.type == ClassIDType.Texture2D)
                            {
                                Texture2D texture2D = new Texture2D(objectReader);
                                if (item.Value.Assets.Contains($"{texture2D.m_Name.ToLower()}.png"))
                                {
                                    FileStream fileStream = File.OpenWrite(Path.Join(outputDirectoryTexture, $"{texture2D.m_Name}.png"));
                                    Image<Bgra32> image = Texture2DExtensions.ConvertToImage(texture2D, true);
                                    AssetStudio.ImageExtensions.WriteToStream(image, fileStream, ImageFormat.Png);
                                    Console.WriteLine("Exported " + texture2D.m_Name);
                                    fileStream.Close();
                                }
                            }
                            else if (objectReader.type == ClassIDType.GameObject)
                            {
                                GameObject gameObject = new GameObject(objectReader);
                                if (item.Value.Assets.Contains($"{gameObject.m_Name.ToLower()}.prefab"))
                                {
                                    foreach (var component in gameObject.m_Components)
                                    {
                                        if (file.ObjectsDic[component.m_PathID].type == ClassIDType.Animator)
                                        {
                                            animatorPathIdDictionary.Add(component.m_PathID, gameObject.m_Name);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (animatorPathIdDictionary.Count != 0)
                    {
                        foreach (SerializedFile file in _assetsManager.assetsFileList)
                        {
                            foreach (ObjectInfo obj in file.m_Objects)
                            {
                                if (animatorPathIdDictionary.ContainsKey(obj.m_PathID))
                                {
                                    ObjectReader objectReader = new ObjectReader(file.reader, file, obj);
                                    Animator animator = new Animator(objectReader);
                                    ModelConverter modelConverter = new ModelConverter(animator, ImageFormat.Png, null);
                                    ModelExporter.ExportFbx(Path.Join(outputDirectoryModel, animatorPathIdDictionary[obj.m_PathID], $"{animatorPathIdDictionary[obj.m_PathID]}.fbx"), modelConverter, true, (float)0.25, true, true, true, true, false, 10, false, (float)10, 3, false);
                                    Console.WriteLine($"Exported {animatorPathIdDictionary[obj.m_PathID]}");
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                    animatorPathIdDictionary.Clear();
                }
            }
        }

        public void ExportSFiles(Dictionary<string, BundleData> sAssetsDictionary)
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "s");
            string outputDirectory = Path.Join(_rootDirectory, "AudioClip");
            if (sAssetsDictionary.Count != 0)
            {
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }
                foreach (var item in sAssetsDictionary)
                {
                    _assetsManager.LoadFiles(Path.Join(assetsDirectory, item.Key));
                    foreach (SerializedFile file in _assetsManager.assetsFileList)
                    {
                        foreach (ObjectInfo obj in file.m_Objects)
                        {
                            ObjectReader objectReader = new ObjectReader(file.reader, file, obj);
                            if (objectReader.type == ClassIDType.AudioClip)
                            {
                                AudioClip audioClip = new AudioClip(objectReader);
                                if (item.Value.Assets.Contains($"{audioClip.m_Name.ToLower()}.wav"))
                                {
                                    AudioClipConverter audioClipConverter = new AudioClipConverter(audioClip);
                                    if (audioClipConverter.IsSupport)
                                    {
                                        byte[] buffer = audioClipConverter.ConvertToWav();
                                        File.WriteAllBytes(Path.Join(outputDirectory, $"{audioClip.m_Name}.wav"), buffer);
                                        Console.WriteLine("Exported " + audioClip.m_Name);
                                    }
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        public void ExportBFiles()
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "b");
            string outputDirectory = Path.Join(_rootDirectory, "Database");
            if (Directory.Exists(assetsDirectory))
            {
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }
                _assetsManager.LoadFolder(assetsDirectory);
                foreach (SerializedFile assetFile in _assetsManager.assetsFileList)
                {
                    foreach (ObjectInfo obj in assetFile.m_Objects)
                    {
                        ObjectReader objectReader = new ObjectReader(assetFile.reader, assetFile, obj);
                        if (objectReader.type == ClassIDType.TextAsset)
                        {
                            TextAsset textAsset = new TextAsset(objectReader);
                            File.WriteAllBytes(Path.Join(outputDirectory, $"{textAsset.m_Name}.csv"), textAsset.m_Script);
                            Console.WriteLine($"Exported {textAsset.m_Name}");
                        }
                    }
                }
                _assetsManager.Clear();
            }
        }

        private readonly AssetsManager _assetsManager = new AssetsManager();

        private readonly string _rootDirectory;
    }
}