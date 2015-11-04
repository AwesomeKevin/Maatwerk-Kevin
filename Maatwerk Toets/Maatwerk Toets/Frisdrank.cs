using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Frisdrank : Verkoop
    {
        //Properties
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; }

        //Constructor
        public Frisdrank(int aantal) : base(aantal)
        {
            BTWTarief.IsHoog = false;
        }

        //Methodes
        public string ToString()
        {
            return BTWTarief.ToString() + ", " + Prijs.ToString();
        }
    }
}
