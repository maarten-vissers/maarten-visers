using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    abstract class  Voertuig
    {
        protected ConsoleColor kleur;
        private Persoon Bestuurder;

        public Voertuig(ConsoleColor kleur)
        {
            this.kleur = kleur;
        }

        public abstract void Rij();
        

        public virtual void Stuur(int graden)
        {
            Console.WriteLine("");
        }

        public Persoon Chauffeur { get; set; }
        
    }

    

    

  
}