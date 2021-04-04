using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Softplan.Challenge.Application.Services.InterestRate.Model.Response;
using Softplan.Challenge.Application.Utils;

namespace Softplan.Challenge.Application.Services.InterestRate
{
    public class InterestRateApiHttpClient : IInterestRateApiHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<InterestRateApiHttpClient> _logger;

        public InterestRateApiHttpClient(HttpClient httpClient,
            ILogger<InterestRateApiHttpClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<GetInterestRateResponse> GetInterestRateAsync(CancellationToken cancellationToken)
        {
            try
            {
                using var httpResponse = await _httpClient.GetAsync("api/1.0/taxajuros", cancellationToken);

                httpResponse.EnsureSuccessStatusCode();

                var response = await httpResponse.ReceiveJson<GetInterestRateResponse>();

                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to get interest rate.");
                throw;
            }
        }

    }
}
