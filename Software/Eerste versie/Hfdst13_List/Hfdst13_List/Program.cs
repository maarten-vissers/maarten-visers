using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hfdst13_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Maarten";
            List<int> huisnummers = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                huisnummers.Add(i);
            }

            huisnummers.Remove(0);
            for (int i = 0; i < huisnummers.Count; i++)
            {
                Console.WriteLine("Huisnummer: " + huisnummers[i]);
            }
            Huisbewoners x = new Huisbewoners();
            

        }
    }
}
