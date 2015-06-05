using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    class SmartLamp : Lamp
    {
        private double aantalMinuten;
        private DateTime laatsteWijziging;

        public void Toggle()
        {
            laatsteWijziging = new DateTime();
            brandend = !brandend;
            aantalMinuten = Convert.ToDouble(DateTime.Now - laatsteWijziging);
        }

        public double Brandtijd
        {
            get { return aantalMinuten; }
            
        }
    }
}
