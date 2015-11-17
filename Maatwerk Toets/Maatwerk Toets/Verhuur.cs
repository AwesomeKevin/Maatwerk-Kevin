using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public abstract class Verhuur : IInkomsten
    {
        //Fields
        private int urenVerhuurd;
        private DateTime tijdstip;
        private BTWTarief btwTarief;
        private decimal prijsPerUur;

        //Properties
        public int UrenVerhuurd
        {
            get { return urenVerhuurd;}
        }
        public decimal Bedrag { get; set; }
        public DateTime Tijdstip
        {
            get { return tijdstip; }
        }
        public abstract BTWTarief BTWTarief
        {
            get;
        }
        public abstract decimal PrijsPerUur
        {
            get;
        }

        //Constructor
        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {
            this.tijdstip = tijdstip;
            this.urenVerhuurd = urenVerhuurd;
        }

        //Methodes
        public override string ToString()
        {
            return UrenVerhuurd.ToString() + ", " + Bedrag.ToString() + ", " + Tijdstip.ToString() + ", " + BTWTarief.ToString() + ", " + PrijsPerUur.ToString();
        }

        public int CompareTo(IInkomsten other)
        {
            Verhuur v = (Verhuur)other;
            if (v.tijdstip > other.Tijdstip) return 1;
            else if (v.tijdstip < other.Tijdstip) return -1;
            else return 0;
        }
    }
}
