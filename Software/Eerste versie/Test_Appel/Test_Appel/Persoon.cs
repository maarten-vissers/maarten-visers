using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Appel
{
    class Persoon
    {
        static Random rndGen = new Random();
        public int Leeftijd { get; set; }
        public string Naam { get; set; }
        public static Persoon GenereerRandomPersoon(string naam)
        {

            
            int x = rndGen.Next(1, 100);
            Persoon persoon = new Persoon();
            persoon.Leeftijd = x;
            persoon.Naam = naam;

            return persoon;

        }
        
    }
}
