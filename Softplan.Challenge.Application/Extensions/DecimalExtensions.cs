using System;

namespace Softplan.Challenge.Application.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal TruncateWithDecimals(this decimal value, int decimals = 2)
        {
            var step = (decimal)Math.Pow(10, decimals);
            var tmp = Math.Truncate(step * value);
            
            return tmp / step;
        }
    }
}
