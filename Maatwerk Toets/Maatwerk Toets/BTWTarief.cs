using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class BTWTarief
    {
        //Properties
        public bool IsHoog { get; set; }

        //Constructor
        public BTWTarief(bool isHoog)
        {
            IsHoog = isHoog;
        }
    }
}
