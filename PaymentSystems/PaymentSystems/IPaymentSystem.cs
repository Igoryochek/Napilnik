using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystems
{
    public interface IPaymentSystem
    {
        public string GetPayingLink();
    }
}
