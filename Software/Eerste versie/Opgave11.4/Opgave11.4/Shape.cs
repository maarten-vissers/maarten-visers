using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Opgave11._4
{
    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public abstract int Area { get; }
        public abstract void Display(Graphics G);
    }

    class Square : Shape {
        public override int Area
        {
            get { throw new NotImplementedException(); }
        }
        public override void Display(Graphics G)
        {
            throw new NotImplementedException();
        }
        

    }




    class Triangle : Shape
    {
        public override int Area
        {
            get { throw new NotImplementedException(); }
        }
        public override void Display(Graphics G)
        {
            throw new NotImplementedException();
        }
    } 


}
