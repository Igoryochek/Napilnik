using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    class Weapon
    {
        private const int Bullit = 1;
        private int _damage;
        private int _bullits;

        public Weapon(int damage,int bullits)
        {
            if (damage<0||bullits<0)
            {
                throw new ArgumentException();
            }

            _damage = damage;
            _bullits = bullits;
        }

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            _bullits -= Bullit;
        }
    }
}
