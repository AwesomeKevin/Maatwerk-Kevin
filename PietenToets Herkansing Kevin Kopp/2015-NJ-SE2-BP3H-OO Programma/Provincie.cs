using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public class Provincie
    {
        public string Naam { get; set; }

        public Provincie(string naam)
        {
            Naam = naam;
        }

        public void VoegGemeenteToe(Gemeente gemeente)
        {
            
        }

        public Gemeente ZoekGemeente(string naam)
        {
            Provincie p = new Provincie("Brabant");
            Gemeente g = new Gemeente("Bladel", p, 2000, 1, 1);
            return g;
        }

        public override string ToString()
        {
            return "return";
        }
    }
}
