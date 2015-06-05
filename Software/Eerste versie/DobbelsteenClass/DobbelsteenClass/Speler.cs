using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelsteenClass
{
    class Speler
    {
        private string naam;
        private int score = 0; 
        public Speler(string naam)
        {
            this.naam = naam;
        }
        public void verhoogPunten()
        {
            this.score++;
        }
        public void resetPunten()
        {
            this.score = 0;
        }
        public int Score
        {
            get { return score; }
        }
        public string Naam
        {
            get { return naam; }
        }
        public string ScoreBord
        {
            get { return naam + " " + score + Environment.NewLine; }
        }

    }
}
