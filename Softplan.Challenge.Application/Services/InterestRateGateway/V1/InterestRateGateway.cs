using System.Threading;
using System.Threading.Tasks;
using Softplan.Challenge.Application.Services.Api1;
using Softplan.Challenge.Domain.Services.V1;

namespace Softplan.Challenge.Application.Services.InterestRateGateway.V1
{
    public class InterestRateGateway : IInterestRateGateway
    {
        private readonly IApi1HttpClient _api1HttpClient;

        public InterestRateGateway(IApi1HttpClient api1HttpClient)
        {
            _api1HttpClient = api1HttpClient;
        }

        public async Task<decimal> GetInterestRateAsync(CancellationToken cancellationToken)
        {
            var response = await _api1HttpClient.GetInterestRateAsync(cancellationToken);

            return response.InterestRate;
        }
    }
}
