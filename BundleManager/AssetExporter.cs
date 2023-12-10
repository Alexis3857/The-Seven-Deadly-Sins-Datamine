using AssetStudio;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System.Text;

namespace _7dsgcDatamine
{
    public static class AssetExporter
    {
        public static void Export(string bundleDirectory, string exportDirectory, Section section, List<BundleData> assetsList, Action<string, BundleData, ObjectReader, SerializedFile> func)
        {
            foreach (BundleData bundleData in assetsList)
            {
                _assetsManager.LoadFiles(Path.Combine(bundleDirectory, section.ToString(), bundleData.Checksum));
                foreach (SerializedFile file in _assetsManager.assetsFileList)
                {
                    foreach (ObjectInfo obj in file.m_Objects)
                    {
                        ObjectReader objectReader = new ObjectReader(file.reader, file, obj);
                        func(exportDirectory, bundleData, objectReader, file);
                    }
                }
                _assetsManager.Clear();
            }
        }

        private static void ExportMain(string exportDirectory, BundleData bundleData, ObjectReader objectReader, SerializedFile file)
        {
            if (objectReader.type == ClassIDType.Texture2D)
            {
                Texture2D texture2D = new Texture2D(objectReader);
                if (bundleData.NewAssetsList.Contains($"{texture2D.m_Name.ToLower()}.png"))
                {
                    FileStream fileStream = File.OpenWrite(Path.Combine(exportDirectory, MainTexture2DFolder, $"{texture2D.m_Name}.png"));
                    Image<Bgra32> image = Texture2DExtensions.ConvertToImage(texture2D, true);
                    AssetStudio.ImageExtensions.WriteToStream(image, fileStream, ImageFormat.Png);
                    Console.WriteLine($"Exported {texture2D.m_Name}.png");
                    fileStream.Close();
                }
            }
            else if (objectReader.type == ClassIDType.GameObject)
            {
                GameObject gameObject = new GameObject(objectReader);
                if (bundleData.NewAssetsList.Contains($"{gameObject.m_Name.ToLower()}.prefab"))
                {
                    foreach (var component in gameObject.m_Components)
                    {
                        if (file.ObjectsDic[component.m_PathID].type == ClassIDType.Animator)
                        {
                            Animator animator = new Animator(file.ObjectsDic[component.m_PathID].reader);
                            ModelConverter modelConverter = new ModelConverter(animator, ImageFormat.Png, null);
                            ModelExporter.ExportFbx(Path.Combine(exportDirectory, MainAnimatorFolder, gameObject.m_Name, $"{gameObject.m_Name}.fbx"), modelConverter, true, (float)0.25, true, true, true, true, false, 10, false, (float)10, 3, false);
                            Console.WriteLine($"Exported {gameObject.m_Name}.fbx");
                            break;
                        }
                    }
                }
            }
        }

        private static void ExportLocalization(string exportDirectory, BundleData bundleData, ObjectReader objectReader, SerializedFile file)
        {
            if (objectReader.type == ClassIDType.TextAsset)
            {
                TextAsset textAsset = new TextAsset(objectReader);
                if (textAsset.m_Name.StartsWith("LocalizeString_"))
                {
                    File.WriteAllBytes(Path.Combine(exportDirectory, LocalizationFolder, $"{textAsset.m_Name}.bytes"), textAsset.m_Script);
                    Console.WriteLine($"Exported {textAsset.m_Name}.bytes");
                }
            }
        }

        private static void ExportSound(string exportDirectory, BundleData bundleData, ObjectReader objectReader, SerializedFile file)
        {
            if (objectReader.type == ClassIDType.AudioClip)
            {
                AudioClip audioClip = new AudioClip(objectReader);
                if (bundleData.NewAssetsList.Contains($"{audioClip.m_Name.ToLower()}.wav"))
                {
                    AudioClipConverter audioClipConverter = new AudioClipConverter(audioClip);
                    if (audioClipConverter.IsSupport)
                    {
                        byte[] buffer = audioClipConverter.ConvertToWav();
                        File.WriteAllBytes(Path.Combine(exportDirectory, SoundFolder, $"{audioClip.m_Name}.wav"), buffer);
                        Console.WriteLine($"Exported {audioClip.m_Name}.wav");
                    }
                }
            }
        }

        private static void ExportBanner(string exportDirectory, BundleData bundleData, ObjectReader objectReader, SerializedFile file)
        {
            if (objectReader.type == ClassIDType.Texture2D)
            {
                Texture2D texture2D = new Texture2D(objectReader);
                if (bundleData.NewAssetsList.Contains($"{texture2D.m_Name.ToLower()}.png"))
                {
                    FileStream fileStream = File.OpenWrite(Path.Combine(exportDirectory, BannerFolder, $"{texture2D.m_Name}.png"));
                    Image<Bgra32> image = Texture2DExtensions.ConvertToImage(texture2D, true);
                    AssetStudio.ImageExtensions.WriteToStream(image, fileStream, ImageFormat.Png);
                    Console.WriteLine($"Exported {texture2D.m_Name}.png");
                    fileStream.Close();
                }
            }
        }

        private static void ExportVoice(string exportDirectory, BundleData bundleData, ObjectReader objectReader, SerializedFile file)
        {
            if (objectReader.type == ClassIDType.AudioClip)
            {
                AudioClip audioClip = new AudioClip(objectReader);
                if (bundleData.NewAssetsList.Contains($"{audioClip.m_Name.ToLower()}.wav"))
                {
                    AudioClipConverter audioClipConverter = new AudioClipConverter(audioClip);
                    if (audioClipConverter.IsSupport)
                    {
                        byte[] buffer = audioClipConverter.ConvertToWav();
                        File.WriteAllBytes(Path.Combine(exportDirectory, VoiceFolder, $"{audioClip.m_Name}.wav"), buffer);
                        Console.WriteLine($"Exported {audioClip.m_Name}.wav");
                    }
                }
            }
        }

        private static void ExportDatabase(string exportDirectory, BundleData bundleData, ObjectReader objectReader, SerializedFile file)
        {
            if (objectReader.type == ClassIDType.TextAsset)
            {
                TextAsset textAsset = new TextAsset(objectReader);
                File.WriteAllBytes(Path.Combine(exportDirectory, DatabaseFolder, $"{textAsset.m_Name}.csv"), textAsset.m_Script);
                Console.WriteLine($"Exported {textAsset.m_Name}.csv");
            }
        }

        private static void ExportWeapon(string exportDirectory, BundleData bundleData, ObjectReader objectReader, SerializedFile file)
        {
            if (objectReader.type == ClassIDType.Mesh)
            {
                Mesh mesh = new Mesh(objectReader);
                if (bundleData.NewAssetsList.Contains($"{mesh.m_Name}.prefab"))
                {
                    string meshOutputDirectory = Path.Combine(exportDirectory, WeaponMeshFolder, mesh.m_Name);
                    Directory.CreateDirectory(meshOutputDirectory);
                    ExportMesh(mesh, meshOutputDirectory);
                    Console.WriteLine($"Exported {mesh.m_Name}.obj");
                }
            }
            else if (objectReader.type == ClassIDType.Texture2D)
            {
                Texture2D texture2D = new Texture2D(objectReader);
                if (bundleData.NewAssetsList.Contains($"{texture2D.m_Name.Replace("_D", string.Empty)}.prefab"))
                {
                    string meshOutputDirectory = Path.Combine(exportDirectory, WeaponMeshFolder, texture2D.m_Name.Replace("_D", string.Empty));
                    Directory.CreateDirectory(meshOutputDirectory);
                    FileStream fileStream = File.OpenWrite(Path.Combine(meshOutputDirectory, $"{texture2D.m_Name}.png"));
                    Image<Bgra32> image = Texture2DExtensions.ConvertToImage(texture2D, true);
                    AssetStudio.ImageExtensions.WriteToStream(image, fileStream, ImageFormat.Png);
                    Console.WriteLine("Exported " + texture2D.m_Name);
                    fileStream.Close();
                }
            }
            else if (objectReader.type == ClassIDType.GameObject)
            {
                GameObject gameObject = new GameObject(objectReader);
                if (bundleData.NewAssetsList.Contains($"{gameObject.m_Name.ToLower()}.prefab"))
                {
                    foreach (var component in gameObject.m_Components)
                    {
                        if (file.ObjectsDic[component.m_PathID].type == ClassIDType.Animator)
                        {
                            Animator animator = new Animator(file.ObjectsDic[component.m_PathID].reader);
                            ModelConverter modelConverter = new ModelConverter(animator, ImageFormat.Png, null);
                            ModelExporter.ExportFbx(Path.Combine(exportDirectory, WeaponAnimatorFolder, gameObject.m_Name, $"{gameObject.m_Name}.fbx"), modelConverter, true, (float)0.25, true, true, true, true, false, 10, false, (float)10, 3, false);
                            Console.WriteLine($"Exported {gameObject.m_Name}.fbx");
                            break;
                        }
                    }
                }
            }
        }

        public static void ExportBmdataFile(string bmdataDirectory, Section section, out byte[]? bundleData, out byte[]? bundlePackData)
        {
            bundleData = null;
            bundlePackData = null;
            _assetsManager.LoadFiles(Path.Combine(bmdataDirectory, section.ToString()));
            foreach (SerializedFile assetFile in _assetsManager.assetsFileList)
            {
                foreach (ObjectInfo obj in assetFile.m_Objects)
                {
                    ObjectReader objectReader = new ObjectReader(assetFile.reader, assetFile, obj);
                    if (objectReader.type == ClassIDType.TextAsset)
                    {
                        TextAsset textAsset = new TextAsset(objectReader);
                        if (textAsset.m_Name == "BundleData")
                        {
                            bundleData = textAsset.m_Script;
                            string fileName = $"{section}_{textAsset.m_Name}.bytes";
                            File.WriteAllBytes(Path.Combine(bmdataDirectory, fileName), textAsset.m_Script);
                            Console.WriteLine($"Exported {fileName}.txt");
                        }
                        else if (textAsset.m_Name == "BundlePackData")
                        {
                            bundlePackData = textAsset.m_Script;
                            string fileName = $"{section}_{textAsset.m_Name}.bytes";
                            File.WriteAllBytes(Path.Combine(bmdataDirectory, fileName), textAsset.m_Script);
                            Console.WriteLine($"Exported {fileName}.txt");
                        }
                    }
                }
            }
            _assetsManager.Clear();
        }

        public static void CreateExportDirectory(string baseDirectory)
        {
            Directory.CreateDirectory(Path.Combine(baseDirectory, MainTexture2DFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, MainAnimatorFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, DatabaseFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, VoiceFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, WeaponMeshFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, WeaponAnimatorFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, LocalizationFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, SoundFolder));
            Directory.CreateDirectory(Path.Combine(baseDirectory, BannerFolder));

        }
        public static void ExportSectionsAssets(string bundleDirectory, string exportDirectory, Section section, List<BundleData> assetList)
        {
            Action<string, BundleData, ObjectReader, SerializedFile> func;
            switch (section)
            {
                case Section.m:
                    func = ExportMain;
                    break;
                case Section.b:
                    func = ExportDatabase;
                    break;
                case Section.s:
                    func = ExportSound;
                    break;
                case Section.w:
                    func = ExportWeapon;
                    break;
                case Section.jal:
                case Section.kol:
                case Section.enl:
                    func = ExportLocalization;
                    break;
                case Section.jas:
                case Section.kos:
                    func = ExportVoice;
                    break;
                case Section.jau:
                case Section.kou:
                case Section.enu:
                    func = ExportBanner;
                    break;
                default:
                    Console.WriteLine($"Can't export the files of section {section}.");
                    return;
            }
            Export(bundleDirectory, exportDirectory, section, assetList, func);
        }

        // https://github.com/Perfare/AssetStudio/blob/d158e864b556b5970709c2a52e47944d53aa98a2/AssetStudioGUI/Exporter.cs#L127
        private static void ExportMesh(Mesh mesh, string outputDirectory)
        {
            string exportFullPath = Path.Combine(outputDirectory, $"{mesh.m_Name}.obj");
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

        private static readonly AssetsManager _assetsManager = new AssetsManager();

        // The folder in which the database will be exported
        public const string DatabaseFolder = "Database";

        // DO NOT CHANGE The folder in which the localization database will be exported
        public const string LocalizationFolder = "Localization";

        // The folder in which the Texture2D from the m section will be exported
        public const string MainTexture2DFolder = "Texture2D";

        // The folder in which the Animators from the m section will be exported
        public const string MainAnimatorFolder = "Animator";

        // The folder in which the banners images from the jau/kou/enu section will be exported
        public const string BannerFolder = "Texture2D";

        // The folder in which the voices audio clips from the jas/kos section will be exported
        public const string VoiceFolder = "AudioClip";

        // The folder in which the voices audio clips from the s section will be exported
        public const string SoundFolder = "AudioClip";

        // The folder in which the mesh weapon will be exported
        public const string WeaponMeshFolder = "Mesh";

        // The folde rin which the Animators weapons will be exported
        public const string WeaponAnimatorFolder = "Animator";
    }
}