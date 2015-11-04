using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Verhuur : Inkomsten
        //Ik heb het woord abstract weggelaten omdat ik niet wist hoe ik anders een nieuwe verhuring moest aanmaken.
    {
        //Properties
        public int UrenVerhuurd { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime Tijdstip { get; set; }
        public abstract BTWTarief BTWTarief { get; set; }
        public abstract decimal PrijsPerUur { get; set; }

        //Constructor
        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {
            Tijdstip = tijdstip;
            UrenVerhuurd = urenVerhuurd;
        }

        //Methodes
        public override string ToString()
        {
            return UrenVerhuurd.ToString() + ", " + Bedrag.ToString() + ", " + Tijdstip.ToString() + ", " + BTWTarief.ToString() + ", " + PrijsPerUur.ToString();
        }
    }
}
