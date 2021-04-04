
namespace Softplan.Challenge.Application.Requests.V1.GetInterestRate
{
    public class GetInterestRateResponse
    {
        /// <summary>
        /// The current interest rate.
        /// </summary>
        public decimal InterestRate { get; set; }

        public GetInterestRateResponse(decimal interestRate)
        {
            InterestRate = interestRate;
        }
    }

}
