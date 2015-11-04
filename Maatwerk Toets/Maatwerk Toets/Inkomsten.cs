using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public interface Inkomsten
    {
        //Properties
        public decimal Bedrag { get; }
        public BTWTarief BTWTarief { get; }
        public DateTime Tijdstip { get; }
    }
}
