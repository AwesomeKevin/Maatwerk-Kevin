using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoT_RPG
{
    public class Speler
    {
        //Properties
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public int Geld { get; set; }
        public int Upgradepunten { get; set; }
        public List<Item> items;

        //Constructors
        public Speler(string voornaam, string tussenvoegsel, string achternaam, int geld, int upgradepunten)
        {
            Voornaam = voornaam;
            Tussenvoegsel = tussenvoegsel;
            Achternaam = achternaam;
            Geld = geld;
            Upgradepunten = upgradepunten;
            items = new List<Item>();
        }

        //Methodes

    }
}
