namespace Softplan.Challenge.Application.Requests.V1.CalculateInterest
{
    public class CalculateInterestResponse
    {
        /// <summary>
        /// The amount of the interest calculation.
        /// </summary>
        public decimal Value { get; set; }

        public CalculateInterestResponse(decimal value)
        {
            Value = value; 
        }

    }
}
