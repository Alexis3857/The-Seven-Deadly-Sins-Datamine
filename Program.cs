using Decryptor;
using Newtonsoft.Json.Linq;

namespace _7dsgcDatamine
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                string configuration = s_configurationDecryptor.Decrypt(GetConfigurationJson("configuration"));
                GetRelativeSubAndVersion(configuration, out string patchRelativeSub, out string patchVersion);
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
            else
            {
                Console.WriteLine("You have to provide a decryption key when executing the program.");
            }
        }

        /* You can get the following files from this function :
         * configuration : patch name, version, server ip
         * notice : maintenance time
         * url_configuration : sns urls and game urls
         * guide_configuration
         * patch_configuration
         * extra_configuration
         * whitelist.json
         */

        public static string GetConfigurationJson(string fileName)
        {
            HttpClient client = new HttpClient();
            return client.GetStringAsync("http://nanatsunotaizai.gcdn.netmarble.com/nanatsunotaizai/config/" + fileName).Result;
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
            Console.WriteLine($"Relative sub : {patchRelativeSub}\nVersion : {patchVersion}\n");
        }

        private static readonly ConfigDecryptor s_configurationDecryptor = new ConfigDecryptor();

        private static BundleManager.BundleManager s_bundleManager;
    }
}