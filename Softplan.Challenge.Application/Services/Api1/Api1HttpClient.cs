using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Softplan.Challenge.Application.Services.Api1.Model.Response;
using Softplan.Challenge.Application.Utils;
using Softplan.Challenge.Domain.Services;

namespace Softplan.Challenge.Application.Services.Api1
{
    public class Api1HttpClient : IApi1HttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<Api1HttpClient> _logger;

        public Api1HttpClient(HttpClient httpClient,
            ILogger<Api1HttpClient> logger)
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
