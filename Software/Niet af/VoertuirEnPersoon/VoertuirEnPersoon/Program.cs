using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoertuirEnPersoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon Maarten = new Persoon();
            Maarten.Voornaam="Maarten";
            Maarten.Achternaam="Vissers";
            Maarten.Geboortedatum = new DateTime(1998, 05, 24);
            Maarten.Postcode = 2980.ToString();

            Voertuig Audi = new Voertuig("Groen");
            Audi.Type = "Audi";
            Audi.Chauffeur = Maarten;

            Audi.Rij();
            Voertuig BMW = new Voertuig();
            BMW.Chauffeur = Maarten;
            BMW.Type = "BMW";

            Console.WriteLine(BMW.Kleur);
            BMW.Rij();
        }
    }
}
