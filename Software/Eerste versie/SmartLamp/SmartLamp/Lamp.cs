using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLamp
{
    class Lamp
    {
        protected bool brandend;

        public void Toggle()
        {
            brandend = !brandend;
        }
        public bool Brandend
        {
            get { return brandend; }
        }
    }
}
