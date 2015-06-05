using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatroonKleur
{
    public partial class Form1 : Form
    {
        public Random rndGen = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.BackColor= Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.Yellow;
            pictureBox4.BackColor = Color.Yellow;
            pictureBox5.BackColor = Color.Yellow;
            pictureBox8.BackColor = Color.Yellow;
            pictureBox11.BackColor = Color.Yellow;
            pictureBox12.BackColor = Color.Yellow;
            pictureBox13.BackColor = Color.Yellow;
            pictureBox14.BackColor = Color.Yellow;
            pictureBox15.BackColor = Color.Yellow;
            

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        
    }
}
