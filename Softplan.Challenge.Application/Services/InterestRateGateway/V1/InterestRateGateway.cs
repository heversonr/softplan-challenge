using System.Threading;
using System.Threading.Tasks;
using Softplan.Challenge.Application.Services.InterestRate;
using Softplan.Challenge.Domain.Services.V1;

namespace Softplan.Challenge.Application.Services.InterestRateGateway.V1
{
    public class InterestRateGateway : IInterestRateGateway
    {
        private readonly IInterestRateApiHttpClient _interestRateApi;

        public InterestRateGateway(IInterestRateApiHttpClient interestRateApi)
        {
            _interestRateApi = interestRateApi;
        }

        public async Task<decimal> GetInterestRateAsync(CancellationToken cancellationToken)
        {
            var response = await _interestRateApi.GetInterestRateAsync(cancellationToken);

            return response.InterestRate;
        }
    }
}
