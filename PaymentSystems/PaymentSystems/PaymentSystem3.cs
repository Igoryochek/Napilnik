using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystems
{
    class PaymentSystem3 : IPaymentSystem, IOrder
    {
        private readonly Order _order;

        public PaymentSystem3(Order order)
        {
            _order = order;
        }

        public string GetPayingLink()
        {
            return "system3.com/pay?amount=" + _order.Amount + "&curency=RUB&hash={SHA-1 хеш "+_order.Amount + _order.Id+"секретный ключ}";
        }

        public void FormOrder()
        {
            Console.WriteLine(GetPayingLink());
        }
    }
}
