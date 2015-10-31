using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoT_RPG
{
    public class Match
    {
        //Properties
        public Karakter Karakter { get; set; }
        public Tegenstander Tegenstander { get; set; }
        public Land Land { get; set; }

        //Constructors
        public Match(Karakter karakter, Tegenstander tegenstander, Land land)
        {
            Karakter = karakter;
            Tegenstander = tegenstander;
            Land = land;
        }

        //Methodes
    }
}
