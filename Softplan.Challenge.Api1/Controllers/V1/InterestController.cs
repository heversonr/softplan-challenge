using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Softplan.Challenge.Application.Requests.V1.GetInterestRate;


namespace Softplan.Challenge.Api1.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{version:apiVersion}/taxajuros")]
    public class InterestController : ControllerBase
    {
        public readonly IMediator _mediator;

        public InterestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Returns the interest rate.
        /// </summary>
        [HttpGet]
        public async Task<GetInterestRateResponse> GetInterestRateAsync(CancellationToken cancellationToken)
        {
            var request = new GetInterestRateRequest();

            return await _mediator.Send(request, cancellationToken);

        }
    }
}
