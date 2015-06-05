using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Ballon ballon;
        private Graphics drawArea;

        public Form1()
        {
            InitializeComponent();

             ballon = new Ballon();
             drawArea = pictureBox1.CreateGraphics(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ballon.MoveRight(20);
            drawArea.Clear(Color.White);
            ballon.Display(drawArea);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ballon.ChangeSize(20);
            drawArea.Clear(Color.White);
            ballon.Display(drawArea);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ballon.xCoord = Convert.ToInt32()
        }

       
    }
}
