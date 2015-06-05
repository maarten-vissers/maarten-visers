using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Appel
{
    class Appel
    {
        private double gewicht;
        private string kleur;
        public Appel(double gewicht, string kleur)
        {
            this.gewicht = gewicht;
            this.kleur = kleur;
        }
       

        public void Eet()
        {
            Console.WriteLine("De appel (" + this.kleur + ")  weegt "+gewicht + " gram");
        }
        public double Gewicht
        {
            get { return gewicht; }
        }
        public string Kleur
        {
            get { return kleur; }
        }

    }
}
