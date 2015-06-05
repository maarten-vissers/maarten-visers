using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW_DNA3
{
    
    class Program
    {
        static Random rndGen = new Random();
        
        static void GenereerDNA(int lengte)
        {
            
            
            string dna = "";
            int da=0;
            int dc=0;
            int dg=0;
            int dt=0;

            for (int i = 0; i <= lengte; i++)
            {
                int x = rndGen.Next(1, 5);
                if (x == 1)
                {
                    dna += "A";
                    da += 1;
                }
                else if (x == 2)
                {
                    dna += "G";
                    dg += 1;
                }
                else if (x == 3)
                {
                    dna += "T";
                    dt += 1;
                }
                else if (x==4)
                {
                    dna += "C";
                    dc += 1;
                }
            }
            Console.WriteLine(dna);
            StringBuilder str = new StringBuilder();
            str.Append("Hoeveel A's; " + da.ToString() + "   ");
            str.Append("Hoeveel T's; " + dt.ToString() + "   ");
            str.Append("Hoeveel C's; " + dc.ToString() + "   ");
            str.Append("Hoeveel G's; " + dg.ToString() + "   ");
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            GenereerDNA(500);
        }
    }
}
