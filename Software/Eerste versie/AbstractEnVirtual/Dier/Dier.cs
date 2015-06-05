using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dier
{
    class Dier 
    {
        public double Gewicht { get; set; }
        public virtual void MaakGeluid()
        {

        }
    }

    class Koe: Dier
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("Meeuuoeeeee!");
        }

    }

    class Paard: Dier
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("HinikHinik!");
        }
    }

    class Varken:Dier
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("KnorKnor...");
        }
    }

}
