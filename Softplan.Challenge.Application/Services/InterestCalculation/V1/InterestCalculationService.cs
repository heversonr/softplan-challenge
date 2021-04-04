using System;
using Softplan.Challenge.Application.Extensions;
using Softplan.Challenge.Domain.Services.V1;

namespace Softplan.Challenge.Application.Services.InterestCalculation.V1
{
    public class InterestCalculationService : IInterestCalculationService
    {
        public decimal Calculate(decimal initialValue, int months, decimal interestRate)
        {
            var result = initialValue * (decimal) Math.Pow((double)interestRate + 1, months);

            return result.TruncateWithDecimals();
        }
    }
}
