using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Softplan.Challenge.Domain.Services.V1;

namespace Softplan.Challenge.Application.Requests.V1.CalculateInterest
{
    public class CalculateInterestRequestHandler : IRequestHandler<CalculateInterestRequest, CalculateInterestResponse>
    {
        private readonly IInterestCalculationService _calculationService;
        private readonly IInterestRateGateway _interestRateGateway;

        public CalculateInterestRequestHandler(IInterestCalculationService calculationService,
            IInterestRateGateway interestRateGateway)
        {
            _calculationService = calculationService;
            _interestRateGateway = interestRateGateway;
        }


        public async Task<CalculateInterestResponse> Handle(CalculateInterestRequest request,
            CancellationToken cancellationToken)
        {
            var rate = await _interestRateGateway.GetInterestRateAsync(cancellationToken);

            var result = _calculationService.Calculate(request.InitialValue, request.Months, rate);

            return new CalculateInterestResponse(result);
        }
    }
}
