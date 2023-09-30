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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");  // Needed to make sure the program writes decimal number with . and not , when exporting Mesh
            Dictionary<string, string> parsedArguments = ParseArguments(args);
            string? decryptionKey;
            string? patchRelativeSub;
            string? patchVersion;
            bool isWriteChangedString = parsedArguments.ContainsKey("write_changed_string");
            if (!parsedArguments.TryGetValue("decryption_key", out decryptionKey))
            {
                Usage();
                return;
            }
            if (!parsedArguments.TryGetValue("patch_relative_sub", out patchRelativeSub) || !parsedArguments.TryGetValue("patch_version", out patchVersion))
            {
                string configuration = s_configurationDecryptor.Decrypt(BundleDownloader.GetConfiguration("configuration").Result);
                GetRelativeSubAndVersion(configuration, out patchRelativeSub, out patchVersion);
            }
            Console.WriteLine($"Relative sub : {patchRelativeSub}\nVersion : {patchVersion}\n");
            string previousVersionFolderName = GetLastVersionFolder(patchVersion).ToString();
            BundleManager.BundleManager bundleManager = new BundleManager.BundleManager(patchRelativeSub, patchVersion, decryptionKey, previousVersionFolderName);
            if (Directory.Exists($"JP/{patchVersion}"))
            {
                Console.Write($"The directory {patchVersion} already exists, do you want to delete it and do the process again ? (y/n) : ");
                string? userInput = Console.ReadLine();
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
                bundleManager.DownloadBaseOnly();
            }
            else
            {
                Console.WriteLine($"Comparing with {previousVersionFolderName}");
                bundleManager.DownloadNew(isWriteChangedString);
            }
            Console.WriteLine("\nEverything was done successfully !");
        }

        public static void Usage()
        {
            Console.WriteLine("Usage: 7dsgcDatamine.exe -key=decryption_key -patch=patch_relative_sub:patch_version -write_changed_string");

            Console.WriteLine("\n-key is mandatory");
            Console.WriteLine("It's the AES decryption passphrase, hidden in the game code and this program can not run without it");
            Console.WriteLine("See https://github.com/Alexis3857/The-Seven-Deadly-Sins-Key-Finder");

            Console.WriteLine("\n-patch is optional");
            Console.WriteLine("patch_relative_sub is the patch name, it changes every week when there's an update");
            Console.WriteLine("patch_version changes when a bug is fixed in a patch");
            Console.WriteLine("If no patch is given, the program will use the current game patch");

            Console.WriteLine("\n-write_changed_string is optional");
            Console.WriteLine("If used, the program will also write strings that got changed and not only new strings");
        }

        public static Dictionary<string, string> ParseArguments(string[] args)
        {
            Dictionary<string, string> arguments = new Dictionary<string, string>();
            foreach (string arg in args)
            {
                if (arg.StartsWith("-key="))
                {
                    arguments.Add("decryption_key", arg.Split("=")[1]);
                }
                else if (arg.StartsWith("-patch="))
                {
                    string patch = arg.Split("=")[1];
                    string[] splitPatch = patch.Split(":");
                    if (splitPatch.Length == 2)
                    {
                        arguments.Add("patch_relative_sub", splitPatch[0]);
                        arguments.Add("patch_version", splitPatch[1]);
                    }
                    else
                    {
                        Console.WriteLine("Argument -patch couldn't be parsed.");
                    }
                }
                else if (arg == "-write_changed_string")
                {
                    arguments.Add("write_changed_string", string.Empty);
                }
            }
            return arguments;
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
    }
}