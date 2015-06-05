using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLampOpnieuw
{
    public partial class Form1 : Form
    {
        public int x = 0;
        private Button b;
        private PictureBox p;
        private Label l;        
        private List<GeplaatsteSmartLamp> lampen;
        private List<Button> lampKnoppen;
        private List<PictureBox> lampControles;
        private List<Label> LampBrandtijd;
        public Form1()
        {
            InitializeComponent();
            lampen = new List<GeplaatsteSmartLamp>();
            lampen.Add(new GeplaatsteSmartLamp("Keuken"));
            lampen.Add(new GeplaatsteSmartLamp("Living"));
            lampen.Add(new GeplaatsteSmartLamp("Woonkamer"));            

            lampKnoppen = new List<Button>();
            lampControles = new List<PictureBox>();
            LampBrandtijd = new List<Label>();
        }

        public void VoegLampControlToe()
        {
            for (int i = 0; i<Convert.ToInt32(lampen.Count());i++)
            {
                b = new Button();
                b.Location = new Point(i  * 120 , 10);
                b.Size = new Size(75, 23);
                b.Tag = lampen[i].Plaats;
                b.Text = lampen[i].Plaats;
                b.Click += b_Click;
                this.Controls.Add(b);
                lampKnoppen.Add(b);

                p = new PictureBox();
                p.Location = new Point(i *120, 60);
                p.Size = new Size(100,100);
                b.Tag = lampen[i].Plaats;
                b.Text = lampen[i].Plaats;
                this.Controls.Add(p);
                
                lampControles.Add(p);

                l = new Label();
                l.Location = new Point(i *120 , 180);
                l.AutoSize = false;
                this.Controls.Add(l);
                LampBrandtijd.Add(l);
                
                
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            x = lampKnoppen.IndexOf(b);

            lampen[x].Toggle();           
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            VoegLampControlToe();
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(lampControles.Count());i++)
            {
                if (lampen[i].Brandend == true)
                {
                    lampControles[i].BackColor = Color.Yellow;
                }
                else if (lampen[i].Brandend == false)
                {
                    lampControles[i].BackColor = Color.Black;
                }
                
                for (int j = 0; j < Convert.ToInt32(lampControles.Count()); j++)
                {
                    LampBrandtijd[j].Text = Convert.ToString(lampen[j].Brandtijd);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
