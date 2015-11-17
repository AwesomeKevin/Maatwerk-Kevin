using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public abstract class Verkoop : IInkomsten
    {
        //Fields
        private int aantal;
        private DateTime tijdstip;
        private BTWTarief btwTarief;
        private decimal prijs;

        //Properties
        public int Aantal
        {
            get { return aantal; }
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
        public abstract decimal Prijs
        {
            get;
        }

        //Constructor
        public Verkoop(int aantal)
        {
            this.aantal = aantal;
            tijdstip = DateTime.Now;
        }

        //Methodes
        public override string ToString()
        {
            return Aantal.ToString() + ", " + Bedrag.ToString() + ", " + Tijdstip.ToString() + ", " + BTWTarief.ToString() + ", " + Prijs.ToString();
        }

        public int CompareTo(IInkomsten other)
        {
            Verkoop v = (Verkoop)other;
            if (v.tijdstip > other.Tijdstip) return 1;
            else if (v.tijdstip < other.Tijdstip) return -1;
            else return 0;
        }
    }
}
