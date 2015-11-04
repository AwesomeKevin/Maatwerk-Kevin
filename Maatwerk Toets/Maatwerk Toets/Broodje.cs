﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Broodje : Verkoop
    {
        //Properties
        public override BTWTarief BTWTarief { get; set; }
        public override decimal Prijs { get; set; }

        //Constructor
        public Broodje(int aantal) : base(aantal)
        {
            
        }

        //Methodes
        public override string ToString()
        {
            return BTWTarief.ToString() + ", " + Prijs.ToString();
        }
    }
}