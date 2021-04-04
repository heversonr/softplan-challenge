using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Softplan.Challenge.Application.Requests.V1.ShowMeTheCode
{
    public class ShowMeTheCodeRequestHandler : IRequestHandler<ShowMeTheCodeRequest, ShowMeTheCodeResponse>
    {
        private readonly IConfiguration _configuration;

        public ShowMeTheCodeRequestHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ShowMeTheCodeResponse> Handle(ShowMeTheCodeRequest request, CancellationToken cancellationToken)
        {
            var gitHuhUrl = _configuration.GetConnectionString("GitHubProjectUrl");

            var response = await Task.Run(() => new ShowMeTheCodeResponse(gitHuhUrl), cancellationToken);

            return response;
        }
    }
}
