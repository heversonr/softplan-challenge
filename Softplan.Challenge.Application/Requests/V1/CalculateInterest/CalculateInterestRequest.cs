using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Softplan.Challenge.Application.Requests.V1.CalculateInterest
{
    public class CalculateInterestRequest : IRequest<CalculateInterestResponse>
    {
        public decimal InitialValue { get; set; }
        public int Months { get; set; }
    }
}
