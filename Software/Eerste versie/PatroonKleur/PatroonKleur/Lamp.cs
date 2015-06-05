using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatroonKleur
{
    class Lamp
    {
        private bool brandend;
        public virtual void Toggle()
        {
            brandend = !brandend;
        }

        public bool Brandend
        {
            get { return brandend; }
        }
       
    }
}
