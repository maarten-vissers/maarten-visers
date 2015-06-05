using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    abstract class Persoon
    {
        public string Naam { get; set; }
        public string Rijbewijs { get; set; }
        public int Leeftijd { get; set; }
        
    }
    class Man : Persoon
    {
        
    }
    class Vrouw : Persoon
    {
        
    }
}
