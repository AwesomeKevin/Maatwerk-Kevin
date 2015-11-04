using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Sportzaal : Verhuur
    {
        //Properties
        public override BTWTarief BTWTarief { get; set; }
        public override decimal PrijsPerUur { get; set; }

        //Constructor
        public Sportzaal(DateTime tijdstip, int urenVerhuurd) : base(tijdstip, urenVerhuurd)
        {
            
        }

        //Methodes
        public override string ToString()
        {
            return "Sportzaal" + ", " + Tijdstip.ToString() + ", " + UrenVerhuurd.ToString();
        }
    }
}
