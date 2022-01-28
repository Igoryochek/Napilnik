using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    class Weapon
    {
        private const int OneBullit = 1;
        private int _damage;
        private int _bullits;

        public Weapon(int damage,int bullits)
        {
            _damage = damage;
            _bullits = bullits;
        }

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            _bullits -= OneBullit;
        }
    }
}
