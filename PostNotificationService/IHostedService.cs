using System.Threading;
using System.Threading.Tasks;

namespace PostNotificationService
{
    public interface IHostedService
    {
        Task StartAsync(CancellationToken cancellationToken);
        Task StopAsync(CancellationToken cancellationToken);
    }
}
