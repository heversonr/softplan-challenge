using Microsoft.AspNetCore.Mvc;
using Softplan.Challenge.Application.Requests.V1.CalculateInterest;
using System.Threading;
using System.Threading.Tasks;
using MediatR;


namespace Softplan.Challenge.Api2.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{version:apiVersion}/calculaJuros")]
    public class InterestCalculationController : ControllerBase
    {
        public readonly IMediator _mediator;

        public InterestCalculationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Returns the interest amount based on the current interest rate.
        /// </summary>
        /// <param name="valorInicial">The initial value</param>
        /// <param name="meses">Number of months</param>
        [HttpGet]
        public async Task<CalculateInterestResponse> CalculateInterestAsync([FromQuery] decimal valorInicial,
            int meses, CancellationToken cancellationToken)
        {
            var request = new CalculateInterestRequest
            {
                InitialValue = valorInicial,
                Months = meses
            };

            return await _mediator.Send(request, cancellationToken);
        }

    }
}
