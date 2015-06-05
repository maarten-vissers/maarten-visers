using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    abstract class Figuur
    {
        public Figuur(System.Drawing.Graphics tekenOppervlakte);
        public Punt Positie { get; set; }
        public Afmeting Grootte { get; set; }
        public abstract double Oppervlakte { get; }
        public void Toon();

    }
}
