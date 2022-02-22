using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode10
{
    public class PaymentSystemCreator
    {
        public PaymentSystem GetPaymentSystem(string systemID)
        {
            if (systemID == "QIWI")
            {
                return new QIWI(systemID);
            }
            else if (systemID == "WebMoney")
            {
                return new WebMoney(systemID);
            }
            else if (systemID == "Card")
            {
                return new Card(systemID);
            }
            else
            {
                return null;
            }
        }
    }
}
