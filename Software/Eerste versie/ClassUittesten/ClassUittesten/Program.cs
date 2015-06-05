using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUittesten
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();

            t.Haha = "yolo";
            Console.WriteLine(t.Haha);
            t.Haha = "wat is yolo";
            Console.WriteLine(t.Haha);
        }
    }
}
