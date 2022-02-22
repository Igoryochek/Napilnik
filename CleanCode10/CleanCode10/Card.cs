using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode10
{
    public class Card : PaymentSystem
    {
        public Card(string systemID) : base(systemID)
        {
        }

        public override void ShowPaymentStart()
        {
            Console.WriteLine("Вызов API банка эмитера карты Card...");
        }

        protected override void ShowPaymentChecking()
        {
            Console.WriteLine("Проверка платежа через Card...");
        }
    }
}
