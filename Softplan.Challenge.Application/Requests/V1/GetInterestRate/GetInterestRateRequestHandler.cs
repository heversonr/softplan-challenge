using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Softplan.Challenge.Application.Requests.V1.GetInterestRate
{
    public class GetInterestRateRequestHandler : IRequestHandler<GetInterestRateRequest, GetInterestRateResponse>
    {
        private const decimal CURRENT_INTEREST_RATE = 0.01M;

        public async Task<GetInterestRateResponse> Handle(GetInterestRateRequest request, CancellationToken cancellationToken)
        {
            var response = await Task.Run(() => new GetInterestRateResponse(CURRENT_INTEREST_RATE), cancellationToken);

            return response;
        }
    }
}
