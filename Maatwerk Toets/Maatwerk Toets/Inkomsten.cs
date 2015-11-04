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
        decimal Bedrag { get; set; }
        BTWTarief BTWTarief { get; set; }
        DateTime Tijdstip { get; set; }
    }
}
