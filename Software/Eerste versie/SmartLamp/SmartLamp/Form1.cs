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
    public partial class Form1 : Form
    {
        private Button b;
        private PictureBox p;
        private Label la;
        private List<Lamp> lampen = new List<Lamp>();

        SmartLamp SL1 = new GeplaatsteSmartLamp("Keuken");
        SmartLamp SL2 = new GeplaatsteSmartLamp("Woonkamer");
       

        public Form1()
        {
            InitializeComponent();
             
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lampen.Add(SL1);
            lampen.Add(SL2);
            VoegLampControlToe(SL1,"Keuken",10);
            VoegLampControlToe(SL2, "Woonkamer", 150);
            
        }
        
        private void VoegLampControlToe(Lamp l,string naam, int x)
        {
            
            lampen.Add(l);
            b = new Button();
            b.Location = new Point(x, 10);
            b.Size = new Size(75, 23);
            b.Tag = naam;
            b.Text = naam;
            b.Click += b_Click;
            this.Controls.Add(b);

            p = new PictureBox();
            p.Location = new Point(x,60);
            p.Size = new Size(100, 100);
            p.Tag = naam;
            p.Text = naam;
            p.BackColor = Color.Black ;
            this.Controls.Add(p);

            la = new Label();
            la.Location = new Point(x, 160);
            la.Tag = naam;
            la.Text = naam;
            this.Controls.Add(la);

            

        }

        void b_Click(object sender, EventArgs e)
        {
            SL1.Toggle();
            SL2.Toggle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
        
    }
}
