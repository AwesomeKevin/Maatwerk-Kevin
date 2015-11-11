using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public interface IInkomsten : IComparable<IInkomsten>
    {
        //Properties
        decimal Bedrag { get; set; }
        BTWTarief BTWTarief { get; set; }
        DateTime Tijdstip { get; set; }

        abstract int CompareTo(IInkomsten inkomst);
    }
}
