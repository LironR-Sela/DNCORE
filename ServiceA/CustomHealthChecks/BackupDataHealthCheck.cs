using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceA.CustomHealthChecks
{
    public class BackupDataHealthCheck : IHealthCheck
    {
        private readonly int _startHour, _endHour;
        public BackupDataHealthCheck(int startHour, int endHour)
        {
            _startHour = startHour;
            _endHour = endHour;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            if (DateTime.Now.Hour >= _startHour && DateTime.Now.Hour <= _endHour)
                return new HealthCheckResult(HealthStatus.Degraded);

            return new HealthCheckResult(HealthStatus.Healthy);
        }
    }
}
