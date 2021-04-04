
using System.Globalization;

namespace Softplan.Challenge.Application.Requests.V1.CalculateInterest
{
    public class CalculateInterestResponse
    {
        /// <summary>
        /// The amount of the interest calculation.
        /// </summary>
        public string Value { get; set; }

        public CalculateInterestResponse(decimal value)
        {
            Value = value.ToString("F", new CultureInfo("pt-BR").NumberFormat); 
        }

    }
}
