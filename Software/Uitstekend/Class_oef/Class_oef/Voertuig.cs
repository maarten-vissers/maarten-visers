using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_oef
{
    class Voertuig
    {



        public string Type { get; set; }
        public string Kleur { get; set; }
        public Persoon Chauffeur { get; set; }
        public Voertuig(string kleur)
        {
            this.Kleur = kleur;
        }
        public void Verf(string kleur)
        {
            this.Kleur = kleur;
        }
        public void Rij()
        {
            if (Chauffeur == null)
            {
                Console.WriteLine("Voertuig kan niet rijden - geen chauffeur aanwezig!");
            }
            else
            {
                Console.WriteLine("De chauffeur (" + Chauffeur.Voornaam +" "+ Chauffeur.Achternaam + ", " + Chauffeur.Leeftijd + "), rijdt met het voertuig van het type: "+this.Type+" (kleur " + Kleur + ").");
            }
            
        }
    }
}
