using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystems
{
    public class Order
    {
        public  int Id { get; private set; }
        public  int Amount { get; private set; }

        public Order(int id, int amount) => (Id, Amount) = (id, amount);

    }
}
