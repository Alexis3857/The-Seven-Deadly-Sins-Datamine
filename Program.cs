using Newtonsoft.Json.Linq;
using System.Globalization;

namespace _7dsgcDatamine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");  // Needed to make sure the program writes decimal number with . and not , when exporting Mesh
            GameCode gameCode;
            string? decryptionKey, patchRelativeSub, patchVersion;
            bool isWriteChangedString;
            ParseArguments(args, out gameCode, out decryptionKey, out patchRelativeSub, out patchVersion, out isWriteChangedString);
            if (string.IsNullOrEmpty(decryptionKey) || gameCode == GameCode.none)
            {
                Usage();
                return;
            }
            if (patchRelativeSub is null || patchVersion is null)  // If the user didn't provide a relative sub or a version, we get the latest ones
            {
                string config = ConfigDecryptor.Decrypt(BundleDownloader.GetConfiguration(gameCode, "configuration").Result);
                ParseConfiguration(config, out patchRelativeSub, out patchVersion);
            }
            Console.WriteLine($"Relative sub : {patchRelativeSub}\nVersion : {patchVersion}\n");
            string currentBaseDirectory = Path.Combine(Directory.GetCurrentDirectory(), gameCode.ToString(), patchVersion);
            string? previousBaseDirectory;
            int lastSavedVersion = GetLastVersionFolder(gameCode, patchVersion);
            if (lastSavedVersion == -1)
                previousBaseDirectory = null;
            else
                previousBaseDirectory = Path.Combine(Directory.GetCurrentDirectory(), gameCode.ToString(), lastSavedVersion.ToString());
            BundleManager bundleManager = new BundleManager(gameCode, new BundleDownloader(gameCode, patchRelativeSub, patchVersion), new BundleDecryptor(decryptionKey), currentBaseDirectory, previousBaseDirectory);

            if (Directory.Exists($"{gameCode}/{patchVersion}"))
            {
                Console.Write($"The directory {patchVersion} already exists, do you want to delete it and do the process again ? (y/n) : ");
                string? userInput = Console.ReadLine();
                while (string.IsNullOrEmpty(userInput) || !userInput.Equals("y", StringComparison.OrdinalIgnoreCase) && !userInput.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Invalid answer, try again : ");
                    userInput = Console.ReadLine();
                }
                if (userInput.Equals("n", StringComparison.OrdinalIgnoreCase))
                    return;
                Directory.Delete($"{gameCode}/{patchVersion}", true);
            }

            Directory.CreateDirectory($"{gameCode}/{patchVersion}");
            if (lastSavedVersion == -1)
            {
                Console.WriteLine("No other version was found to compare with, only the necessary files will be downloaded so this version can be used for the next update.");
                bundleManager.DownloadBase();
            }
            else
            {
                Console.WriteLine($"Comparing with {lastSavedVersion}");
                bundleManager.DownloadNew(isWriteChangedString);
            }
        }

        private static void Usage()
        {
            Console.WriteLine("Usage: 7dsgcDatamine.exe -game=game -key=decryption_key -patch=patch_relative_sub:patch_version -write_changed_string");

            Console.WriteLine("\n-game is mandatory");
            Console.WriteLine("It's the game version to datamine, it must be either JP, KR or GB");

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

        private static void ParseArguments(string[] args, out GameCode gameCode, out string? decKey, out string? relSub, out string? version, out bool writeChangedStr)
        {
            gameCode = GameCode.none;
            decKey = null;
            relSub = null;
            version = null;
            writeChangedStr = false;
            foreach (string arg in args)
            {
                if (arg.StartsWith("-key="))
                {
                    decKey = arg.Split("=")[1];
                }
                else if (arg.StartsWith("-game"))
                {
                    switch (arg.Split("=")[1].ToUpper())
                    {
                        case "JP":
                            gameCode = GameCode.nanatsunotaizai;
                            break;
                        case "KR":
                            gameCode = GameCode.nanakr;
                            break;
                        case "GB":
                            gameCode = GameCode.nanagb;
                            break;
                    }
                }
                else if (arg.StartsWith("-patch="))
                {
                    string patch = arg.Split("=")[1];
                    string[] splitPatch = patch.Split(":");
                    if (splitPatch.Length == 2)
                    {
                        relSub = splitPatch[0];
                        version = splitPatch[1];
                    }
                    else
                    {
                        Console.WriteLine("Argument -patch couldn't be parsed.");
                    }
                }
                else if (arg == "-write_changed_string")
                {
                    writeChangedStr = true;

                }
            }
        }

        private static void ParseConfiguration(string jsonText, out string patchRelativeSub, out string patchVersion)
        {
            JObject json = JObject.Parse(jsonText);  // TODO : null check
            patchRelativeSub = (string)json["patch"]["windows"]["relative_sub"];
            patchVersion = (string)json["patch"]["windows"]["version"];
        }

        // This data saved in this folder will be compared with the new update data
        public static int GetLastVersionFolder(GameCode gameCode, string patchVersion)
        {
            string gameDir = gameCode.ToString();
            int highestDir = -1;
            if (!Directory.Exists(gameDir))
            {
                Directory.CreateDirectory(gameDir);
                return highestDir;
            }
            foreach (DirectoryInfo directoryInfo in new DirectoryInfo(gameDir).GetDirectories())
            {
                if (!patchVersion.Equals(directoryInfo.Name) && int.TryParse(directoryInfo.Name, out int directoryName) && directoryName > highestDir)
                {
                    highestDir = directoryName;
                }
            }
            return highestDir;
        }
    }

    public enum GameCode
    {
        none,
        nanatsunotaizai,
        nanakr,
        nanagb
    }

    // The bundles are splitted in several folders
    public enum Section
    {
        m,  // models + most images
        b,  // database
        s,  // sounds
        w,  // weapons models
        jal, kol, enl,  // japanese, korean and english localization
        jas, kos,  // japanese and korean voices (there is no english voice)
        jau, kou, enu,  // japanese, korean and english banners (images with text on it that differ for each version)
    }

    // Unused sections found in the game code : 
    /* kr (contains censored assets)
     * us (?)
     * n (?)
     * dbg (debug) 
     */
}