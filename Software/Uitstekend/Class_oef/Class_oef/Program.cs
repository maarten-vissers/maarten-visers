using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_oef
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Persoon A = new Persoon();
            A.Geboortedatum = new DateTime(1997, 09, 16);
            A.Voornaam = "Faggot";
            A.Achternaam = "Fagot";
            
            Console.WriteLine(A.Geboortedatum);
            Console.WriteLine(A.Leeftijd);
            Voertuig auto = new Voertuig("Rood");
            auto.Type = "auto";
            auto.Verf("Blauw");
            auto.Rij();
            auto.Chauffeur = A;
            auto.Rij();
            Console.WriteLine("Kies Auto kleur...");
            string kleur = Console.ReadLine();
            auto.Verf(kleur);
            A.Voornaam="Greg";
            A.Achternaam="ShrekSwek";
            auto.Rij();


        }
    }
}
