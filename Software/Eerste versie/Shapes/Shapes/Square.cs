using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public override double Area
        {
            get { throw new NotImplementedException(); }
        }
        public override void Display(System.Drawing.Graphics g)
        {
            g.DrawRectangle(pen, x, y, Width, Heigth);
        }

    }
}
