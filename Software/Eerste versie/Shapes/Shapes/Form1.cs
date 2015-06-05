using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    
    public partial class Form1 : Form
    {
        Graphics paper;
        public Form1()
        {
            
            InitializeComponent();
            paper = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Shape t = new Square();
            t.x = 50;
            t.y = 50;
            t.Width = 30;
            t.Heigth = 30;
            t.Display(paper);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
