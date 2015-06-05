using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Ballon
    {
        private int x = 5;
        private int y = 50;
        private int diameter = 20;
        private Pen pen = new Pen(Color.Black);

        public void MoveRight(int xStep)
        {
            x = x + xStep;
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
        }

        public void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, x, y, diameter, diameter);
        }
        
        public int xCoord
        {
            get { return x; }
            set { x = value; }
        }
        

    }
}
