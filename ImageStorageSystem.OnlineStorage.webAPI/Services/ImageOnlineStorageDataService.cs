using ImageStorageSystem.Backend.Lib.Infra;
using ImageStorageSystem.Lib.Models;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ImageStorageSystem.OnlineStorage.webAPI.Services
{
    public class ImageOnlineStorageDataService : IImageStorageDataService
    {
        private readonly HttpClient _httpClient;

        public ImageOnlineStorageDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<ImageInfo>> GetImages()
        {
            var allFiles = new string[] {
                "https://www.bmw.co.il/content/dam/bmw/common/all-models/m-series/m3-sedan/2020/overview/bmw-3-series-sedan-m-automobiles-sp-desktop.jpg.asset.1627456506127.jpg",
                "https://www.bmw.co.il/content/dam/bmw/common/topics/fascination-bmw/bmw-m-gmbh/M_Introduction/BMW-m-safety-cars-02.jpg",
                "https://www.bmw.co.il/content/dam/bmw/common/all-models/4-series/convertible/2020/highlights/bmw-4-series-convertible-st-xxl.jpg"
            };

            var images = new List<ImageInfo>();
            foreach (var url in allFiles)
            {
                images.Add(new ImageInfo
                {
                    FileName = Path.GetFileName(url),
                    RawData = await _httpClient.GetByteArrayAsync(url)
                });
            }

            return images;
        }
    }
}
