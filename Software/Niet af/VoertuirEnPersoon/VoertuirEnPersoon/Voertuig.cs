using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoertuirEnPersoon
{
    class Voertuig
    {
        public string Type { get; set; }
       

        public string Kleur { get; set; }
        public Persoon Chauffeur { get; set; }
        public Voertuig ()
        {
            Kleur = "Rood";
        }
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
                Console.WriteLine("Er zit niemand in de auto dus deze kan niet rijden.");
            }
            else
            {
                Console.WriteLine(Chauffeur.Voornaam + 
                    " " + Chauffeur.Achternaam + 
                    " zit in de " + this.Type+ 
                    " met de kleur: " + this.Kleur+ " Zijn leeftijd is " + Chauffeur.Leeftijd + " jaar.");
            }
        }

    }
}
