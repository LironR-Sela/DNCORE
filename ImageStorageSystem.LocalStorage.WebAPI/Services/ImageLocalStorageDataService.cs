using ImageStorageSystem.Backend.Lib.Infra;
using ImageStorageSystem.Lib.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ImageStorageSystem.LocalStorage.WebAPI.Services
{
    public class ImageLocalStorageDataService : IImageStorageDataService
    {
        private readonly IConfiguration _configuration;
        public ImageLocalStorageDataService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IList<ImageInfo>> GetImages()
        {
            var imagePath = _configuration["ImageDirectory"];

            var allFiles = Directory.GetFiles(imagePath);
            var images = new List<ImageInfo>();
            foreach (var file in allFiles)
            {
                images.Add(new ImageInfo
                {
                    FileName = Path.GetFileName(file),
                    RawData = File.ReadAllBytes(file)
                });
            }

            return images;
        }
    }
}
