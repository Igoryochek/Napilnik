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

        public event Action Died;

        public void TakeDamage(int damage)
        {
            int currentHealth = Health - damage;
            if (currentHealth <= 0)
            {
                Died.Invoke();
                throw new InvalidOperationException();
            }
            Health = currentHealth;       
        }
    }
}
