using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lamp
{
    public partial class Form1 : Form
    {
        Lamp woonkamer = new Lamp();
        Lamp keuken = new Lamp();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            woonkamer.Toggle();
            label1.Text = Convert.ToString(woonkamer.aantalLampen);
                  }
          

        private void button2_Click(object sender, EventArgs e)
        {
            keuken.Toggle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (keuken.Brandend==true)
            {
                pictureBox2.BackColor = Color.Yellow;

            }
            else
            {
                pictureBox2.BackColor = Color.Black;

            }

            if (woonkamer.Brandend==true)
            {
                pictureBox1.BackColor = Color.Yellow;
                
            }
            else
            {
                pictureBox1.BackColor = Color.Black;
            }
        }
    }
}
