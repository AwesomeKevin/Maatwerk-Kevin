using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public class PakjesPiet : Piet
    {
        private bool isCreatief;
        private bool kanRijmen;
        private bool snaptComputers;

        public override bool IsCreatief
        {
            get { return isCreatief; }
        }

        public override bool KanRijmen
        {
            get { return kanRijmen; }
        }

        public override bool SnaptComputers
        {
            get { return snaptComputers; }
        }

        public PakjesPiet()
        {

        }

        public override string ToString()
        {
            return "return";
        }
    }
}
