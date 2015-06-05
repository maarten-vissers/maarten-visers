using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hfdst13_List_Trollnaam
{
    class Program
    {

        
        static string GenerateTrollnaam()
        {
            Random rndGen = new Random();
            int get = 0;
            int get2=0;
            int get3 = 0;
            int get4 = 0;
            string naam;
            
            
            List<string> mk = new List<string>() { "Z", "M", "K", "L", "G","N","B","R","T","P","K"};
            List<string> k = new List<string>() { "A", "O", "U", "E" };
            get =  rndGen.Next(0, 11);
            get2 = rndGen.Next(0, 4);
            get3 = rndGen.Next(0, 11);
            get4 = rndGen.Next(0, 4);
            naam = "Uw trollnaam is: " + mk[get] + k[get2] + mk[get3] + k[get4];
            
            return naam;

            
            



        }

        static void Main(string[] args)
        {
            string x;
            string y;
            string d;
            int c = 1;

            Random rndGen2 = new Random();


            if (rndGen2.Next(1, 5) == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (rndGen2.Next(1, 5) == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (rndGen2.Next(1, 5) == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (rndGen2.Next(1, 5) == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.DarkCyan;

            }

            Console.WriteLine(GenerateTrollnaam());
        }
    }
}
