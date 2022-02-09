using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode3
{
    class Weapon
    {
        private int _bullets;
        private const int Zero=0;
        private const int OneBullet=1;

        public bool CanShoot() => _bullets > Zero;

        public void Shoot() => _bullets -= OneBullet;
    }
}
