using System;

namespace PaymentSystems
{
    class Program
    {
        static void Main(string[]args)
        {
            Order order = new Order(1522,12000);

            PaymentSystem1 paymentSystem1 = new(order);
            PaymentSystem2 paymentSystem2 = new(order);
            PaymentSystem3 paymentSystem3 = new(order);

            paymentSystem1.FormOrder();
            paymentSystem2.FormOrder();
            paymentSystem3.FormOrder();
        }
    }
}
