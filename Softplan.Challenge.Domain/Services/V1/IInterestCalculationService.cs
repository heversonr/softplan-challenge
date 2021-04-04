using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.Challenge.Domain.Services.V1
{
    public interface IInterestCalculationService
    {
        decimal Calculate(decimal initialValue, int months, decimal interestRate);
    }
}
