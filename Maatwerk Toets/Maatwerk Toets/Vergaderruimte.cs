using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Vergaderruimte : Verhuur
    {
        //FIelds
        private BTWTarief btwTarief;
        private decimal prijsPerUur;

        //Properties
        public override BTWTarief BTWTarief
        {
            get { return btwTarief; }
        }
        public override decimal PrijsPerUur
        {
            get { return prijsPerUur; }
        }

        //Constructor
        public Vergaderruimte(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {
            btwTarief = BTWTarief.Laag;
            prijsPerUur = 18;
        }

        //Methodes
        public override string ToString()
        {
            return "Vergaderruimte - " + base.ToString();
        }
    }
}
