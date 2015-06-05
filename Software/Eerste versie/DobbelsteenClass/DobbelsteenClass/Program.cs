using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenClass
{
    class Program
    {
        
        
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
            else if (rndGen2.Next(1,5) == 2)
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
            
            
            Dobbelsteen d1 = new Dobbelsteen();
            d1.Rol();
            

             Console.WriteLine("Welkom bij Palace Of Gamble, raad wat het getal is. Indien u niet meer wilt meedoen typ: stop anders typ: doe mee");
             x = Console.ReadLine();
             if (x=="stop")
             {
                 Console.Clear();
             }
             else if (x == "doe mee")
             {
               
                 Console.WriteLine("Welkom in het spel, geef uw naam:");
                 y= Console.ReadLine();
                 Speler speler1 = new Speler(y);
                 Console.WriteLine("De dobbelsteen is geworpen en de waarde is gevonden. Gok het getal, " + y + ".");
                 d = Console.ReadLine();

                
                 while (Convert.ToInt32(d) != d1.Waarde)
                 {
                     Console.WriteLine("Gok opnieuw, " + speler1.Naam);
                     d = Console.ReadLine();

                     
                     c++;

                  }

                 Console.WriteLine("U hebt juist geraden, dit na maar " + c + " pogingen! ");
             }
             else
             {
                 Console.WriteLine("Invoer is niet juist. ");
             }
            

            
        }
    }
}
