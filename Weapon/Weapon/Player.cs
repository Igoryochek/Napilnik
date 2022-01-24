using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    class Player
    {
        public int Health { get; private set; }

        public void TakeDamage(int damage)
        {
            int currentDamage = Health - damage;
            if (currentDamage <= 0)
                throw new InvalidOperationException();
            else
                Health = currentDamage;
        }
    }
}
