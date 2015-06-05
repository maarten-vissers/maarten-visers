using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLampOpnieuw
{
    class SmartLamp : Lamp
    {
        Timer timer = new Timer();
        int aantalSeconden = 0;

        public SmartLamp()
        {
            timer.Tick += timer_Tick;
        }

        public void Toggle()
        {
            timer.Interval = 1000;
            brandend = !brandend;

            if (brandend == true)
            {
                
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            aantalSeconden++;
        }

        public int Brandtijd
        {
            get { return aantalSeconden; }
        }
    }
}
