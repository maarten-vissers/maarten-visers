using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    
        class Vrachtwagen : Voertuig
        {
            

            public Vrachtwagen()
                : base(ConsoleColor.Green)
            {
            }

            public Vrachtwagen(ConsoleColor kleur)
                : base(kleur)
            {
                this.kleur = kleur;
            }

            public override void Rij()
            {
                Console2.WriteLine("De {{vrachtwagen}} rijdt...", ConsoleColor.White, kleur);
            }

            public override void Stuur(int graden)
            {
                Console2.WriteLine("De vrachtwagenchauffeur kijkt in zijn dode-hoek-spiegel",kleur);
                base.Stuur(graden);
            }

            public void LaadLeeg()
            {
            }
        }
    }

