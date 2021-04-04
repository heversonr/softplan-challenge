using Microsoft.AspNetCore.Mvc;
using Softplan.Challenge.Application.Requests.V1.CalculateInterest;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Softplan.Challenge.Application.Requests.V1.ShowMeTheCode;


namespace Softplan.Challenge.Api2.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{version:apiVersion}/showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ShowMeTheCodeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Returns the url with the project source.
        /// </summary>
        [HttpGet]
        public async Task<ShowMeTheCodeResponse> ShowMeTheCodeAsync(CancellationToken cancellationToken)
        {
            var request = new ShowMeTheCodeRequest();

            return await _mediator.Send(request, cancellationToken);
        }
    }
}
