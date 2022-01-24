using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Cart : Store
    {
        public Shop Shop { get; private set; }
        public string Paylink { get; private set; }

        public Cart(Shop shop)
        {
            Shop = shop;
        }
        public override void Add(Product newProduct, int count)
        {
            if (Shop.WareHouse.TryGetProduct(newProduct, count))
            {
                base.Add(newProduct, count);
            }
            else
            {
                Console.WriteLine("NotEnoughGoods!!!");
            }
        }

        public void Order()
        {
            string paylink = Shop.Paylink.ToString();
            Paylink = paylink;
        }
    }
}
