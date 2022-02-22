using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode10
{
    public class QIWI : PaymentSystem
    {
        public QIWI(string systemID) : base(systemID)
        {
        }

        public override void ShowPaymentStart()
        {
            Console.WriteLine("Перевод на страницу QIWI...");
        }

        protected override void ShowPaymentChecking()
        {
            Console.WriteLine("Проверка платежа через QIWI...");
        }
    }
}
