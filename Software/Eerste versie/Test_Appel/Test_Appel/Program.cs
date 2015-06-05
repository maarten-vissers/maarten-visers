using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Appel
{
    class Program
    {
        static void Main(string[] args)
        {
            Appel Gap = new Appel(121, "groen");
            Appel Rap = new Appel(134, "rood");

            Gap.Eet();
            Rap.Eet();

            Peer peer1 = new Peer();
            Peer peer2 = new Peer();
            peer1.Gewicht = 118;
            peer2.Gewicht = 105;
            peer1.Eet();

            Persoon Marc = Persoon.GenereerRandomPersoon("Marc");
            Console.WriteLine(Marc.Leeftijd);
            Persoon kak = Persoon.GenereerRandomPersoon("kak");
            Console.WriteLine(kak.Leeftijd);


        }
    }
}
