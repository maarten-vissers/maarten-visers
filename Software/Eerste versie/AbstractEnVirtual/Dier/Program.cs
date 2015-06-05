using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dier
{
    class Program
    {
        static void Main(string[] args)
        {
           Dier Marc = new Varken();
           Marc.MaakGeluid();

           Gebouw Kak = new Villa();
           Kak.status();
            
        }
    }
}
