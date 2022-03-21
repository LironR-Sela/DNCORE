using ImageStorageSystem.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImageStorageSystem.Backend.Lib.Infra
{
    public interface IImageStorageDataService
    {
        Task<IList<ImageInfo>> GetImages();
    }
}
