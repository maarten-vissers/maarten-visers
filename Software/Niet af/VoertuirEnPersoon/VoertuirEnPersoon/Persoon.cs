using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoertuirEnPersoon
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Postcode { get; set; }
        public DateTime Geboortedatum { get; set; }
        public int Leeftijd
        {
            get { return (DateTime.Now.Year - Geboortedatum.Year); }
        }
    }
}
