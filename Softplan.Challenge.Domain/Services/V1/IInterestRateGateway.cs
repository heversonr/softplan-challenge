using System.Threading;
using System.Threading.Tasks;

namespace Softplan.Challenge.Domain.Services.V1
{
    public interface IInterestRateGateway
    {
        Task<decimal> GetInterestRateAsync(CancellationToken cancellationToken);
    }
}
