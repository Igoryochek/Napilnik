using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode10
{
    public class WebMoney : PaymentSystem
    {
        public WebMoney(string systemID) : base(systemID)
        {
        }

        public override void ShowPaymentStart()
        {
            Console.WriteLine("Вызов API WebMoney...");
        }

        protected override void ShowPaymentChecking()
        {
            Console.WriteLine("Проверка платежа через WebMoney...");
        }
    }
}
