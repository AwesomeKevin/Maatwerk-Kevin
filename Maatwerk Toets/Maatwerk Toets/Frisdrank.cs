using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Frisdrank : Verkoop
    {
        //FIelds
        private BTWTarief btwTarief;
        private decimal prijs;

        //Properties
        public override BTWTarief BTWTarief
        {
            get { return btwTarief; }
        }
        public override decimal Prijs
        {
            get { return prijs; }
        }

        //Constructor
        public Frisdrank(int aantal) 
            : base(aantal)
        {
            btwTarief = BTWTarief.Hoog;
            prijs = 6;
        }

        //Methodes
        public override string ToString()
        {
            return "Frisdrank - " + base.ToString();
        }
    }
}
