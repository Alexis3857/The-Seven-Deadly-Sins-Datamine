using Decryptor;
using Newtonsoft.Json.Linq;
using System.Globalization;
using BundleManager;

namespace _7dsgcDatamine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");  // Needed to make sure the program writes decimal number with . and not ,
            if (args.Length != 1 && args.Length != 3)
            {
                Console.WriteLine("Usage: 7dsgcDatamine.exe decryption_key patch_relative_sub patch_version\nwhere patch_relative_sub and patch_version are optional.");
                return;
            }
            string patchRelativeSub;
            string patchVersion;
            if (args.Length == 1)
            {
                string configuration = s_configurationDecryptor.Decrypt(BundleDownloader.GetConfiguration("configuration").Result);
                GetRelativeSubAndVersion(configuration, out patchRelativeSub, out patchVersion);
            }
            else
            {
                patchRelativeSub = args[1];
                patchVersion = args[2];

            }
            Console.WriteLine($"Relative sub : {patchRelativeSub}\nVersion : {patchVersion}\n");
            string previousVersionFolderName = GetLastVersionFolder(patchVersion).ToString();
            s_bundleManager = new BundleManager.BundleManager(patchRelativeSub, patchVersion, args[0], previousVersionFolderName);
            if (Directory.Exists($"JP/{patchVersion}"))
            {
                Console.Write($"The directory {patchVersion} already exists, do you want to delete it and do the process again ? (y/n) : ");
                string userInput = Console.ReadLine();
                while (string.IsNullOrEmpty(userInput) || !userInput.ToLower().Equals("y") && !userInput.ToLower().Equals("n"))
                {
                    Console.Write("Invalid answer, try again : ");
                    userInput = Console.ReadLine();
                }
                if (userInput.ToLower().Equals("y"))
                {
                    Directory.Delete($"JP/{patchVersion}", true);
                }
                else
                {
                    Console.WriteLine($"The directory {patchVersion} already exists.");
                    return;
                }
            }
            Directory.CreateDirectory($"JP/{patchVersion}");
            if (previousVersionFolderName.Equals("-1"))
            {
                Console.WriteLine("No other version was found to compare with, only the necessary files will be downloaded so this version can be used for the next update.");
                s_bundleManager.DownloadBaseOnly();
            }
            else
            {
                Console.WriteLine($"Comparing with {previousVersionFolderName}");
                s_bundleManager.Process();
            }
            Console.WriteLine("\nEverything was done successfully !");
        }

        // This folder will be compared with the new version of the game to filter the new files
        public static int GetLastVersionFolder(string patchVersion)
        {
            int highestDir = -1;
            if (!Directory.Exists("JP"))
            {
                Directory.CreateDirectory("JP");
                return highestDir;
            }
            foreach (DirectoryInfo directoryInfo in new DirectoryInfo("JP").GetDirectories())
            {
                if (!patchVersion.Equals(directoryInfo.Name) && int.TryParse(directoryInfo.Name, out int directoryName) && directoryName > highestDir)
                {
                    highestDir = directoryName;
                }
            }
            return highestDir;
        }

        public static void GetRelativeSubAndVersion(string jsonText, out string patchRelativeSub, out string patchVersion)
        {
            JObject json = JObject.Parse(jsonText);
            patchRelativeSub = (string)json["patch"]["windows"]["relative_sub"];
            patchVersion = (string)json["patch"]["windows"]["version"];
        }

        private static readonly ConfigDecryptor s_configurationDecryptor = new ConfigDecryptor();

        private static BundleManager.BundleManager s_bundleManager;
    }
}