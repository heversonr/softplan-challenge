using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Softplan.Challenge.Application.Services.Api1;
using Softplan.Challenge.Application.Services.InterestCalculation.V1;
using Softplan.Challenge.Application.Services.InterestRateGateway.V1;
using Softplan.Challenge.Domain.Services.V1;

namespace Softplan.Challenge.Application.Extensions
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(assembly);

            services.AddSingleton<IInterestCalculationService, InterestCalculationService>();
            services.AddTransient<IInterestRateGateway, InterestRateGateway>();

            services.AddHttpClient<IApi1HttpClient, Api1HttpClient>(client =>
            {
                client.BaseAddress = new Uri(configuration.GetConnectionString("Api1Endpoint"));
            });

            return services;
        }
    }
}
