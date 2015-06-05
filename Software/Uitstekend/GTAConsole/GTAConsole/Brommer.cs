using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    class Brommer : Voertuig
    {

        public Brommer() : base(ConsoleColor.Magenta)
        {

        }

        public Brommer(ConsoleColor kleur) : base(kleur)
        {

        }

        public override void Rij()
        {
            Console2.WriteLine("De {{brommer}} rijdt...", ConsoleColor.White, kleur);
        }
        public override void Stuur(int Graden)
        {
            
            Console2.WriteLine("De {{brommer}} kijkt rond...", ConsoleColor.White, kleur);
        }
    }
}
