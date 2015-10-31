using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoT_RPG
{
    public class Personage
    {
        //Properties
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public int Levens { get; set; }

        //Constructors
        public Personage(string voornaam, string tussenvoegsel, string achternaam, int levens)
        {
            Voornaam = voornaam;
            Tussenvoegsel = tussenvoegsel;
            Achternaam = achternaam;
            Levens = levens;
        }

        //Methodes
    }
}
