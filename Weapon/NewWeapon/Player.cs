using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWeapon
{
    class Player
    {
        public int Health { get; private set; }

        public void TakeDamage(int damage)
        {
            int health = Health - damage;
            if (health <= 0)
            {
                throw new InvalidOperationException();
            }

            Health = health;
        }
    }
}
