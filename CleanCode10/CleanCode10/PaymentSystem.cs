using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode10
{
    public abstract class PaymentSystem
    {
        public string SystemID { get; private set; }

        public PaymentSystem(string systemID)
        {
            SystemID = systemID;
        }

        public abstract void ShowPaymentStart();

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Вы оплатили с помощью {SystemID}");
            ShowPaymentChecking();
            Console.WriteLine("Оплата прошла успешно!");
        }

        protected abstract void ShowPaymentChecking();
    }
}
