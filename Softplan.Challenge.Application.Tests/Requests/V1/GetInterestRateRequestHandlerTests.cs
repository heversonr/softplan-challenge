using System.Threading;
using System.Threading.Tasks;
using Softplan.Challenge.Application.Requests.V1.GetInterestRate;
using Xunit;

namespace Softplan.Challenge.Application.Tests.Requests.V1
{
    public class GetInterestRateRequestHandlerTests
    {
        [Fact]
        public async Task Handle_WithRequest_ReturnCurrentRate()
        {
            // Arrange
            var request = new GetInterestRateRequest();

            // Act
            var handler = new GetInterestRateRequestHandler();
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(0.01M,result.InterestRate);
        }
    }
}
