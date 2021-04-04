using System.Threading;
using System.Threading.Tasks;
using Softplan.Challenge.Application.Services.Api1.Model.Response;

namespace Softplan.Challenge.Application.Services.Api1
{
    public interface IApi1HttpClient
    {
        Task<GetInterestRateResponse> GetInterestRateAsync(CancellationToken cancellationToken);
    }
}
