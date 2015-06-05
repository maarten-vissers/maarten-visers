using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLampOpnieuw
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
