using System;

namespace CleanCode10
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderForm = new OrderForm();
            string systemId = orderForm.ShowForm();
            var paymentSystemCreator = new PaymentSystemCreator();
            PaymentSystem paymentSystem = paymentSystemCreator.GetPaymentSystem(systemId);
            if (paymentSystem == null)
            {
                Console.WriteLine("Ошибка,система не распознана! Зайдите в программу заново!");
            }
            else
            {
                paymentSystem.ShowPaymentStart();
                paymentSystem.ShowPaymentResult();
            }
        }
    }
}
