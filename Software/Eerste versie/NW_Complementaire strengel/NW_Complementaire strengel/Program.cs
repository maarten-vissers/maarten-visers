using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW_Complementaire_strengel
{
    class Program
    {
        static void ComplementaireStrengel(string strengel)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strengel.Length; i++)
            {
                if (strengel[i] == 'A' || strengel[i] == 'a')
                {
                    sb.Append('T');
                }
                else if (strengel[i] == 'G' || strengel[i] == 'g')
                {
                    sb.Append('C');
                }
                else if (strengel[i] == 'C' || strengel[i] == 'c')
                {
                    sb.Append('G');
                }
                else if (strengel[i] == 'T' || strengel[i] == 't')
                {
                    sb.Append('A');
                }
                else
                {
                    sb.Append('/');
                }

            }
            Console.WriteLine("Hoofdletters: ja/nee");
            string x = Console.ReadLine();
            if (x == "ja" || x == "Ja")
            {
                Console.WriteLine(strengel.ToUpper());
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine(strengel.ToLower());
                Console.WriteLine(sb);
            }
            
        }
        
        static void Main(string[] args)
        {
            ComplementaireStrengel("agatacgbqsdfqsdfqs");
           
        }
    }
}
