using System.Threading;
using System.Threading.Tasks;
using Softplan.Challenge.Application.Services.InterestRate.Model.Response;

namespace Softplan.Challenge.Application.Services.InterestRate
{
    public interface IInterestRateApiHttpClient
    {
        Task<GetInterestRateResponse> GetInterestRateAsync(CancellationToken cancellationToken);
    }
}
