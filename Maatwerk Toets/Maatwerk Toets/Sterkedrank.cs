using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Sterkedrank : Verkoop
    {
        //Properties
        public override BTWTarief BTWTarief { get; protected set; }
        public override decimal Prijs { get; protected set; }

        //Constructor
        public Sterkedrank(int aantal)
            : base(aantal)
        {
            
        }

        //Methodes
        public override string ToString()
        {
            return "Sterkedrank - " + base.ToString();
        }
    }
}
