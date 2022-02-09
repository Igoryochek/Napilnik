using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode6
{
    class Example
    {
        class Player { }
        class Gun { }
        class Target { }
        class Squad
        {
            public IReadOnlyCollection<Unit> UnitsToGet { get; private set; }
        }
        class Unit { }
    }
}
