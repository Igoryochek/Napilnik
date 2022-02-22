using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWeapon
{
    class Bot
    {
        private Weapon _weapon;

        public Bot(Weapon weapon)
        {
            if (weapon == null)
            {
                throw new ArgumentException();
            }

            _weapon = weapon;
        }

        public Bot()
        {
        }

        public void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }
}
