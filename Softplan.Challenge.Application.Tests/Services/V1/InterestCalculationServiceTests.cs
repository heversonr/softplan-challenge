using Softplan.Challenge.Application.Services.InterestCalculation.V1;
using Xunit;

namespace Softplan.Challenge.Application.Tests.Services.V1
{
    public class InterestCalculationServiceTests
    {
        [Theory]
        [InlineData(100, 5, 0.01, 105.10)]
        [InlineData(135, 7, 0.01, 144.73)]
        [InlineData(218, 2, 0.01, 222.38)]
        public void Calculate_ReturnExpectedValue(decimal initialValue, int months, decimal interestRate, decimal expectedValue)
        {
            // Arrange
            var service = GetService();

            // Act
            var result = service.Calculate(initialValue, months, interestRate);

            // Assert
            Assert.Equal(expectedValue, result);
        }

        public static InterestCalculationService GetService() => new();
    }
}
