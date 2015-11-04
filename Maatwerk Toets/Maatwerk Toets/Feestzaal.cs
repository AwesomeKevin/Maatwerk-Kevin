using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Feestzaal : Verhuur
    {
        //Properties
        public BTWTarief BTWTarief { get; }
        public decimal PrijsPerUur { get; }

        //Constructor
        public Feestzaal(DateTime tijdstip, int urenVerhuurd) : base(tijdstip, urenVerhuurd)
        {
            BTWTarief.IsHoog = true;
        }

        //Methodes
        public string ToString()
        {
            return BTWTarief.ToString() + ", " + PrijsPerUur.ToString();
        }
    }
}
