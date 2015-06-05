using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    
    class Lamp
    {
        int x = 0;
        
        protected bool brandend;

        public void Toggle()
        {
            brandend = !brandend;
        }

        public bool Brandend
        {
            get {return brandend;}
        }

        public Lamp()
        {
            x++;
        }

        public int aantalLampen
        {
            get { return x; }
        }



        public string Brandtijd { get; set; }
    }
}
