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
        public override BTWTarief BTWTarief { get; set; }
        public override decimal PrijsPerUur { get; set; }

        //Constructor
        public Feestzaal(DateTime tijdstip, int urenVerhuurd) : base(tijdstip, urenVerhuurd)
        {
            PrijsPerUur = 25;
        }

        //Methodes
        public override string ToString()
        {
            return "Feestzaal" + ", " + Tijdstip.ToString() + ", " + UrenVerhuurd.ToString();
        }
    }
}
