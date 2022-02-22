using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode11
{
    class Example
    {
        public void OnEnable()
        {
            _effects.StartEnableAnimation();
        }

        public void OnDisable()
        {
            _pool.Free(this);
        }
    }
}
