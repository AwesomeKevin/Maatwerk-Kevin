using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Broodje : Verkoop
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
        public Broodje(int aantal)
            : base(aantal)
        {
            btwTarief = BTWTarief.Laag;
            prijs = 4;
        }

        //Methodes
        public override string ToString()
        {
            return "Broodje - " + base.ToString();
        }
    }
}
