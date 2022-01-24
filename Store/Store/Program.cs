using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Product iPhone12 = new Product("IPhone 12");
            Product iPhone11 = new Product("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Add(iPhone12, 10);
            warehouse.Add(iPhone11, 1);

            warehouse.ShowInfo();

            Cart cart = shop.Cart();
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3);

            cart.ShowInfo();
            cart.Order();
            Console.WriteLine("Paylink: " + cart.Paylink);

            cart.Add(iPhone12, 9);
            shop.WareHouse.ShowInfo();
        }
    }
}
