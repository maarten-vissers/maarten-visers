using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLampOpnieuw
{
    class GeplaatsteSmartLamp : SmartLamp
    {
        private string plaats;

        public GeplaatsteSmartLamp(string plaats)
        {
            this.plaats = plaats;
        }

        public string Plaats
        {
            get { return plaats; }
        }
    }
}
