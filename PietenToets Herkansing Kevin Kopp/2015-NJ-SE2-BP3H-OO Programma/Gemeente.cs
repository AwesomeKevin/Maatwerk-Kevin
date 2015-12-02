using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public class Gemeente
    {
        public string Naam { get; set; }
        public int AantalKinderen { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Gemeente(string naam, Provincie provincie, int aantalKinderen, int x, int y)
        {
            Naam = naam;
            X = x;
            Y = y;
        }

        public int AfstandTot(Gemeente gemeente)
        {
            return 0;
        }

        public override string ToString()
        {
            return "return";
        }
    }
}
