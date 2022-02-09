using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystems
{
    class PaymentSystem2: IPaymentSystem, IOrder
    {
        private readonly Order _order;

        public PaymentSystem2(Order order)
        {
            _order = order;
        }

        public string GetPayingLink()
        {
            return "pay.system1.ru/order?amount=" + _order.Amount + "RUB&hash={MD5 хеш " +_order.Id + "}";
        }

        public void FormOrder()
        {
            Console.WriteLine(GetPayingLink());
        }
    }
}
