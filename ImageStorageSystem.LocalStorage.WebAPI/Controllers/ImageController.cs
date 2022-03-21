using ImageStorageSystem.Backend.Lib.Infra;
using ImageStorageSystem.Lib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImageStorageSystem.LocalStorage.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageStorageDataService _imageDataService;

        public ImageController(IImageStorageDataService imageDataService)
        {
            _imageDataService = imageDataService;
        }

        [HttpGet]
        public async Task<IList<ImageInfo>> Get()
        {
            return await _imageDataService.GetImages();
        }
    }
}
