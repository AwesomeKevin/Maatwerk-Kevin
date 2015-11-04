using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Vergaderruimte : Verhuur
    {
        //Properties
        public override BTWTarief BTWTarief { get; set; }
        public override decimal PrijsPerUur { get; set; }

        //Constructor
        public Vergaderruimte(DateTime tijdstip, int urenVerhuurd) : base(tijdstip, urenVerhuurd)
        {
            
        }

        //Methodes
        public override string ToString()
        {
            return "Vergaderruimte" + ", " + Tijdstip.ToString() + ", " + UrenVerhuurd.ToString();
        }
    }
}
