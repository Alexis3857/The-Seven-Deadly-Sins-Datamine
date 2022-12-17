using System.IO.Compression;

namespace BundleManager
{
    public class BundleDownloader
    {
        public BundleDownloader(string patchRelativeSub, string patchVersion)
        {
            _patchRelativeSub = patchRelativeSub;
            _patchVersion = patchVersion;
        }

        // unity bundle file that contains TextAsset that have information needed to filter and download the new bundles
        public async Task<byte[]> DownloadBmdataFile(string folder)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_downloadURL}/{_patchRelativeSub}/{_patchVersion}/{folder}/bmdata");
            byte[] responseBody = await response.Content.ReadAsByteArrayAsync();
            Console.WriteLine($"Downloaded {folder} bmdata");
            return responseBody;
        }

        // zip archive containing the unity bundles
        public async Task DownloadBundlePackFile(string folder, List<string> bundlePackNameList)
        {
            string outputDirectory = $"JP/{_patchVersion}/Bundles/{folder}/";
            Directory.CreateDirectory(outputDirectory);
            foreach (string bundlePackName in bundlePackNameList)
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{_downloadURL}/{_patchRelativeSub}/{_patchVersion}/{folder}/{bundlePackName}");
                MemoryStream responseBody = new MemoryStream(await response.Content.ReadAsByteArrayAsync());
                ZipArchive zip = new ZipArchive(responseBody);
                zip.ExtractToDirectory(outputDirectory);
                Console.WriteLine($"Downloaded and extracted archive {bundlePackName}.zip");
            }
        }

        private readonly HttpClient _httpClient = new HttpClient();

        private const string _downloadURL = "http://nanatsunotaizai.gcdn.netmarble.com/nanatsunotaizai/bundle/windows64bit/astc";

        private readonly string _patchRelativeSub;

        private readonly string _patchVersion;
    }
}