﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GTAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig truck = new Vrachtwagen(ConsoleColor.Red);
            

            truck.Rij();
            truck.Stuur(50);

            Voertuig moto = new Brommer(ConsoleColor.Red);

            moto.Rij();
            moto.Stuur(50);
            Persoon M = new Man();
            
        }
    }
}