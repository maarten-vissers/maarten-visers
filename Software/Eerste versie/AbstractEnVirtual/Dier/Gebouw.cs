using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dier
{
    abstract class Gebouw
    {
        public abstract void status();
    }

    class Villa:Gebouw
    {
        public override void status()
        {
            Console.WriteLine("Foking rijk man");
        }
    }
}
