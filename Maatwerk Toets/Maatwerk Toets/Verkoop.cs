﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public abstract class Verkoop : Inkomsten
    {
        //Properties
        public int Aantal { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime Tijdstip { get; set; }
        public abstract BTWTarief BTWTarief { get; set; }
        public abstract decimal Prijs { get; set; }

        //Constructor
        public Verkoop(int aantal)
        {
            Aantal = aantal;
        }

        //Methodes
        public override string ToString()
        {
            return Aantal.ToString() + ", " + Bedrag.ToString() + ", " + Tijdstip.ToString() + ", " + BTWTarief.ToString() + ", " + Prijs.ToString();
        }
    }
}
