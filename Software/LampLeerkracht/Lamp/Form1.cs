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
        // Elke lamp declareren we als een class-variabele in het formulier:
        private Lamp keukenLamp;
        private Lamp woonkamerLamp;
        private Lamp slaapkamerLamp;
        private Lamp zolderkamerLamp;


        // De constructor v.h. formulier initialiseert alle lampen
        // en start de timer die de lampControles (de PictureBoxen)
        // zal updaten.
        public Form1()
        {
            InitializeComponent();

            keukenLamp = new Lamp();
            woonkamerLamp = new Lamp();
            slaapkamerLamp = new Lamp();
            zolderkamerLamp = new Lamp();

            timer1.Interval = 10; // elke 10 ms updaten we de lampControles
            timer1.Start();
        }


        // Deze method is een mooi voorbeeld van hoe we code zoveel mogelijk
        // kunnen herbruiken en ons niet steeds voor elke lamp willen herhalen.
        private void UpdateLampControle(Lamp lamp, PictureBox lampControle)
        {
            if (lamp.Brandend)
            {
                lampControle.BackColor = Color.Yellow;
            }
            else
            {
                lampControle.BackColor = Color.Black;
            }
        }


        // We steken het updaten van alle lampen in 1 method,
        // zodat we deze method eventueel op verschillende plaatsen
        // kunnen aanroepen.
        private void UpdateLampControles()
        {
            UpdateLampControle(keukenLamp, keukenLampControle);
            UpdateLampControle(woonkamerLamp, woonkamerLampControle);
            UpdateLampControle(slaapkamerLamp, slaapkamerLampControle);
            UpdateLampControle(zolderkamerLamp, zolderkamerLampControle);
        }


        /*
         We gaan ervan uit dat deze applicatie een domotica-controle-systeem is.
         Met de buttons van deze applicatie kunnen we weliswaar de lampen
         aan- en uit schakelen maar het kan ook zijn dat iemand op een
         echte fysieke schakelaar in een kamer drukt, waardoor de toestand
         v.d. lamp veranderd.

         D.w.z. dat we steeds moeten opvragen wat de huidige toestand v.d. lampen is.

         Dit doen we met deze timer-event-handler.
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLampControles();
        }


        // De volgende event-handlers zorgen er enkel voor dat de toestand
        // v.d. lampen veranderd worden:

        private void keukenButton_Click(object sender, EventArgs e)
        {
            keukenLamp.Toggle();
        }

        private void woonkamerButton_Click(object sender, EventArgs e)
        {
            woonkamerLamp.Toggle();
        }

        private void slaapkamerButton_Click(object sender, EventArgs e)
        {
            slaapkamerLamp.Toggle();
        }

        private void zolderkamerButton_Click(object sender, EventArgs e)
        {
            zolderkamerLamp.Toggle();
        }
    }
}
