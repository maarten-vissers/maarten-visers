using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLamp
{
    class SmartLamp : Lamp
    {
        private double aantalMinuten = 0;
        private DateTime laatsteWijziging;
        private Timer timer = new Timer();
        

        //public void Toggle()
        //{
        //    brandend = !brandend;
        //    if (brandend == true)
        //    {
        //        laatsteWijziging = new DateTime();
        //    }
        //    else
        //    {
        //        aantalMinuten += Convert.ToDouble(DateTime.Now) - Convert.ToDouble(laatsteWijziging);
        //    }
        //}

      public void Toggle()
        {
            timer.Tick += timer_Tick;
            timer.Interval = 1000;
          
            brandend = !brandend;
            timer.Start();
          if (brandend == true)
          {
              aantalMinuten += Convert.ToInt32(timer.Tick);
          }
          
          
        }

      void timer_Tick(object sender, EventArgs e)
      {
          if (brandend == true)
          {
              //picturebox = geel
              // seconden optellen met tick
          }
          else if (brandend == false)
          {
              //picturebox = zwart
          }
      }
        

        
        public double Brandtijd
        {
            get { return Convert.ToDouble(aantalMinuten); }
        }

    }
}
