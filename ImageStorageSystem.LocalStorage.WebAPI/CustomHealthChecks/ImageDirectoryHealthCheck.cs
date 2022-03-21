using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ImageStorageSystem.LocalStorage.WebAPI.CustomHealthChecks
{
    public class ImageDirectoryHealthCheck : IHealthCheck
    {
        private readonly string _imagePath;

        public ImageDirectoryHealthCheck(string imagePath)
        {
            _imagePath = imagePath;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            if (Directory.Exists(_imagePath) && Directory.GetFiles(_imagePath).Any())
                return new HealthCheckResult(HealthStatus.Healthy);

            return new HealthCheckResult(HealthStatus.Unhealthy);
        }
    }
}
