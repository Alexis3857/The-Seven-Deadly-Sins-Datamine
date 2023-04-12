using AssetStudio;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System.Text;

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
                            Console.WriteLine($"Exported {fileName}.txt");
                        }
                    }
                }
            }
            _assetsManager.Clear();
        }

        private void ExportJalFiles(Dictionary<string, BundleData> jalAssetsDictionary)
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "jal");
            string outputDirectory = Path.Join(_rootDirectory, "Localization");
            if (Directory.Exists(assetsDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
                foreach (var item in jalAssetsDictionary)
                {
                    _assetsManager.LoadFiles(Path.Join(assetsDirectory, item.Key));
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
                                    Console.WriteLine($"Exported {textAsset.m_Name}.bytes");
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        private void ExportJasFiles(Dictionary<string, BundleData> jasAssetsDictionary)
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
                                        Console.WriteLine($"Exported {audioClip.m_Name}.wav");
                                    }
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        private void ExportJauFiles(Dictionary<string, BundleData> jauAssetsDictionary)
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
                                    Console.WriteLine($"Exported {texture2D.m_Name}.png");
                                    fileStream.Close();
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        private void ExportMFiles(Dictionary<string, BundleData> mAssetsDictionary)
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
                                    Console.WriteLine($"Exported {texture2D.m_Name}.png");
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
                                            Animator animator = new Animator(file.ObjectsDic[component.m_PathID].reader);
                                            ModelConverter modelConverter = new ModelConverter(animator, ImageFormat.Png, null);
                                            ModelExporter.ExportFbx(Path.Join(outputDirectoryModel, gameObject.m_Name, $"{gameObject.m_Name}.fbx"), modelConverter, true, (float)0.25, true, true, true, true, false, 10, false, (float)10, 3, false);
                                            Console.WriteLine($"Exported {gameObject.m_Name}.fbx");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        private void ExportSFiles(Dictionary<string, BundleData> sAssetsDictionary)
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
                                        Console.WriteLine($"Exported {audioClip.m_Name}");
                                    }
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        private void ExportBFiles(Dictionary<string, BundleData> bAssetsDictionary)
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "b");
            string outputDirectory = Path.Join(_rootDirectory, "Database");
            if (Directory.Exists(assetsDirectory))
            {
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }
                foreach (var item in bAssetsDictionary)
                {
                    _assetsManager.LoadFiles(Path.Join(assetsDirectory, item.Key));
                    foreach (SerializedFile assetFile in _assetsManager.assetsFileList)
                    {
                        foreach (ObjectInfo obj in assetFile.m_Objects)
                        {
                            ObjectReader objectReader = new ObjectReader(assetFile.reader, assetFile, obj);
                            if (objectReader.type == ClassIDType.TextAsset)
                            {
                                TextAsset textAsset = new TextAsset(objectReader);
                                File.WriteAllBytes(Path.Join(outputDirectory, $"{textAsset.m_Name}.csv"), textAsset.m_Script);
                                Console.WriteLine($"Exported {textAsset.m_Name}.csv");
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        private void ExportMesh(Mesh mesh, string outputDirectory)
        {
            string exportFullPath = Path.Join(outputDirectory, $"{mesh.m_Name}.obj");
            var sb = new StringBuilder();
            sb.AppendLine("g " + mesh.m_Name);
            #region Vertices
            int c = 3;
            if (mesh.m_Vertices.Length == mesh.m_VertexCount * 4)
            {
                c = 4;
            }
            for (int v = 0; v < mesh.m_VertexCount; v++)
            {
                sb.AppendFormat("v {0} {1} {2}\r\n", -mesh.m_Vertices[v * c], mesh.m_Vertices[v * c + 1], mesh.m_Vertices[v * c + 2]);
            }
            #endregion

            #region UV
            if (mesh.m_UV0?.Length > 0)
            {
                c = 4;
                if (mesh.m_UV0.Length == mesh.m_VertexCount * 2)
                {
                    c = 2;
                }
                else if (mesh.m_UV0.Length == mesh.m_VertexCount * 3)
                {
                    c = 3;
                }
                for (int v = 0; v < mesh.m_VertexCount; v++)
                {
                    sb.AppendFormat("vt {0} {1}\r\n", mesh.m_UV0[v * c], mesh.m_UV0[v * c + 1]);
                }
            }
            #endregion

            #region Normals
            if (mesh.m_Normals?.Length > 0)
            {
                if (mesh.m_Normals.Length == mesh.m_VertexCount * 3)
                {
                    c = 3;
                }
                else if (mesh.m_Normals.Length == mesh.m_VertexCount * 4)
                {
                    c = 4;
                }
                for (int v = 0; v < mesh.m_VertexCount; v++)
                {
                    sb.AppendFormat("vn {0} {1} {2}\r\n", -mesh.m_Normals[v * c], mesh.m_Normals[v * c + 1], mesh.m_Normals[v * c + 2]);
                }
            }
            #endregion

            #region Face
            int sum = 0;
            for (var i = 0; i < mesh.m_SubMeshes.Length; i++)
            {
                sb.AppendLine($"g {mesh.m_Name}_{i}");
                int indexCount = (int)mesh.m_SubMeshes[i].indexCount;
                var end = sum + indexCount / 3;
                for (int f = sum; f < end; f++)
                {
                    sb.AppendFormat("f {0}/{0}/{0} {1}/{1}/{1} {2}/{2}/{2}\r\n", mesh.m_Indices[f * 3 + 2] + 1, mesh.m_Indices[f * 3 + 1] + 1, mesh.m_Indices[f * 3] + 1);
                }
                sum = end;
            }
            #endregion

            sb.Replace("NaN", "0");
            File.WriteAllText(exportFullPath, sb.ToString());
        }

        private void ExportWFiles(Dictionary<string, BundleData> wAssetsDictionary)
        {
            string assetsDirectory = Path.Join(_rootDirectory, "Bundles", "w");
            string outputDirectory = Path.Join(_rootDirectory, "Mesh");
            string outputDirectoryModel = Path.Join(_rootDirectory, "Animator");
            if (Directory.Exists(assetsDirectory))
            {
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }
                foreach (var item in wAssetsDictionary)
                {
                    _assetsManager.LoadFiles(Path.Join(assetsDirectory, item.Key));
                    foreach (SerializedFile file in _assetsManager.assetsFileList)
                    {
                        foreach (ObjectInfo obj in file.m_Objects)
                        {
                            ObjectReader objectReader = new ObjectReader(file.reader, file, obj);
                            if (objectReader.type == ClassIDType.Mesh)
                            {
                                Mesh mesh = new Mesh(objectReader);
                                if (item.Value.Assets.Contains($"{mesh.m_Name}.prefab"))
                                {
                                    string meshOutputDirectory = Path.Join(outputDirectory, mesh.m_Name);
                                    Directory.CreateDirectory(meshOutputDirectory);
                                    ExportMesh(mesh, meshOutputDirectory);
                                    Console.WriteLine($"Exported {mesh.m_Name}.obj");
                                }
                            }
                            else if (objectReader.type == ClassIDType.Texture2D)
                            {
                                Texture2D texture2D = new Texture2D(objectReader);
                                if (item.Value.Assets.Contains($"{texture2D.m_Name.Replace("_D", string.Empty)}.prefab"))
                                {
                                    string meshOutputDirectory = Path.Join(outputDirectory, texture2D.m_Name.Replace("_D", string.Empty));
                                    Directory.CreateDirectory(meshOutputDirectory);
                                    FileStream fileStream = File.OpenWrite(Path.Join(meshOutputDirectory, $"{texture2D.m_Name}.png"));
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
                                            Animator animator = new Animator(file.ObjectsDic[component.m_PathID].reader);
                                            ModelConverter modelConverter = new ModelConverter(animator, ImageFormat.Png, null);
                                            ModelExporter.ExportFbx(Path.Join(outputDirectoryModel, gameObject.m_Name, $"{gameObject.m_Name}.fbx"), modelConverter, true, (float)0.25, true, true, true, true, false, 10, false, (float)10, 3, false);
                                            Console.WriteLine($"Exported {gameObject.m_Name}.fbx");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    _assetsManager.Clear();
                }
            }
        }

        public void ExportFolderFiles(string folder, Dictionary<string, BundleData> dict)
        {
            switch (folder)
            {
                case "b":
                    ExportBFiles(dict);
                    break;
                case "jal":
                    ExportJalFiles(dict);
                    break;
                case "jas":
                    ExportJasFiles(dict);
                    break;
                case "jau":
                    ExportJauFiles(dict);
                    break;
                case "m":
                    ExportMFiles(dict);
                    break;
                case "s":
                    ExportSFiles(dict);
                    break;
                case "w":
                    ExportWFiles(dict);
                    break;
            }
        }

        private readonly AssetsManager _assetsManager = new AssetsManager();

        private readonly string _rootDirectory;
    }
}