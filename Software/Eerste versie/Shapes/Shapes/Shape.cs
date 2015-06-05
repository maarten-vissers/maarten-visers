using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Shapes
{
    abstract class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public abstract double Area {get;}
       
        
        public Pen pen = new Pen(Color.Black);
        public abstract void Display(System.Drawing.Graphics g);

        

    }


}
