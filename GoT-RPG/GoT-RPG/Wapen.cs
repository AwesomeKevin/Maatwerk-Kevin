using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoT_RPG
{
    public class Wapen
    {
        //Properties
        public string Naam { get; set; }
        public int Schade { get; set; }

        //Constructors
        public Wapen(string naam, int schade)
        {
            Naam = naam;
            Schade = schade;
        }
    }
}
