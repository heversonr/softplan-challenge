using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Softplan.Challenge.Application.Extensions;
using Xunit;

namespace Softplan.Challenge.Application.Tests.Extensions
{
    public class DecimalExtenionsTests
    {
        [Theory]
        [InlineData(10.511, 10.51, 2)]
        [InlineData(10.512, 10.51, 2)]
        [InlineData(10.513, 10.51, 2)]
        [InlineData(10.514, 10.51, 2)]
        [InlineData(10.515, 10.51, 2)]
        [InlineData(10.516, 10.51, 2)]
        [InlineData(10.517, 10.51, 2)]
        [InlineData(10.518, 10.51, 2)]
        [InlineData(10.519, 10.51, 2)]
        [InlineData(10.51, 10.51, 2)]
        [InlineData(10.526, 10.52, 2)]
        [InlineData(10.534, 10.53, 2)]
        [InlineData(10.5299878, 10.529, 3)]
        public void TruncateWithDecimals_ReturnExpectedValue(decimal value, decimal expectedValue, int decimals)
        {
            var result = value.TruncateWithDecimals(decimals);

            Assert.Equal(expectedValue, result);
        }
    }
}
