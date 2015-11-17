using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Sportzaal : Verhuur
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
        public Sportzaal(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {
            btwTarief = BTWTarief.Laag;
            prijsPerUur = 15;
        }

        //Methodes
        public override string ToString()
        {
            return "Sportzaal - " + base.ToString();
        }
    }
}
