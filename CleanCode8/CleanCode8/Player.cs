using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode8
{
    class Player
    {
        private string _name;
        private int _age;
        private int _damage;
        private float _cooldown;
        private float _directionX;
        private float _directionY;
        private float _speed;

        public string Name => _name;
        public float Cooldown => _cooldown;
        public float DirectionX => _directionX;
        public float DirectionY => _directionY;
        public int Age => _age;
        public int Damage => _damage;
        public float Speed => _speed;

        private void Move()
        {
            //Do move
        }

        private void Attack()
        {
            //attack
        }

        private bool IsReloading()
        {
            throw new NotImplementedException();
        }
    }
}
}
