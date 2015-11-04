using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public abstract class Verhuur : Inkomsten
    {
        //Properties
        public int UrenVerhuurd { get; set; }
        public decimal Bedrag { get; }
        public DateTime Tijdstip { get; set; }
        public abstract BTWTarief BTWTarief { get; }
        abstract decimal PrijsPerUur { get; }

        //Constructor
        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {
            Tijdstip = tijdstip;
            UrenVerhuurd = urenVerhuurd;
        }

        //Methodes
        public string ToString()
        {
            return UrenVerhuurd.ToString() + ", " + Bedrag.ToString() + ", " + Tijdstip.ToString() + ", " + BTWTarief.ToString() + ", " + PrijsPerUur.ToString();
        }
    }
}
