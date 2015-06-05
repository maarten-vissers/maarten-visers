using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenClass
{
    class Dobbelsteen
    {
        private static Random rndGen = new Random();
        private int aantalOgen { get; set; }



        public void Rol()
        {
            aantalOgen = rndGen.Next(1, 7); 
        }

        public int Waarde
        {
            get { return aantalOgen;}
        }
    }
}
