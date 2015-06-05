using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Appel
{
    class Peer
    {
        public double Gewicht { set; get; }
        public void Eet()
        {
            Console.WriteLine("De peer weegt {0}g", Gewicht);
        }
    }
}
