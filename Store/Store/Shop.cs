using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Shop
    {
        private List<Cart> _carts = new List<Cart>();

        public Warehouse WareHouse { get; private set; }
        public int Paylink { get; private set; }


        public Shop(Warehouse wareHouse)
        {
            WareHouse = wareHouse;
        }

        public Cart Cart()
        {
            Cart cart = new Cart(this);
            _carts.Add(cart);
            Paylink++;
            return cart;
        }
    }
}
