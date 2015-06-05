using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    class Lamp
    {
        private bool brandend; // instantie-variabele

        public void Toggle() // method
        {
            brandend = !brandend;
        }

        public bool Brandend {
            get { return brandend; }
        }
    }
}
