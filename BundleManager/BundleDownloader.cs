using ServiceStack;

namespace _7dsgcDatamine
{
    public class BundleDownloader
    {
        public BundleDownloader(GameCode gameCode, string patchRelativeSub, string patchVersion)
        {
            _gameCode = gameCode;
            _patchRelativeSub = patchRelativeSub;
            _patchVersion = patchVersion;
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

        public static async Task<string> GetConfiguration(GameCode gameCode, string configFile)
        {
            string configuration = await _httpClient.GetStringAsync(_configurationURL.FormatWith(gameCode) + configFile);
            return configuration;
        }

        // unity bundle file that contains TextAsset that have information needed to filter and download the new bundles
        public async Task<byte[]?> DownloadBmdataFile(Section section)
        {
            return await DownloadBundlePackFile(section, "bmdata");
        }

        // zip archive containing the unity bundles
        public async Task<byte[]?> DownloadBundlePackFile(Section section, string bundlePackName)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_downloadURL.FormatWith(_gameCode, _patchRelativeSub, _patchVersion, section, bundlePackName));
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine($"Resource at {_patchRelativeSub}/{_patchVersion}/{section}/{bundlePackName} does not exist.");
                return null;
            }
            return await response.Content.ReadAsByteArrayAsync();
        }

        private static readonly HttpClient _httpClient = new HttpClient();

        private const string _configurationURL = "http://{0}.gcdn.netmarble.com/{0}/config/";

        private const string _downloadURL = "http://{0}.gcdn.netmarble.com/{0}/bundle/windows64bit/astc/{1}/{2}/{3}/{4}";

        private readonly GameCode _gameCode;

        private readonly string _patchRelativeSub;

        private readonly string _patchVersion;
    }
}