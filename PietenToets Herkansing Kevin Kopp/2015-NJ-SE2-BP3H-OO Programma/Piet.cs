using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public abstract class Piet
    {
        private bool isCreatief;
        private bool kanRijmen;
        private bool snaptComputers;

        public abstract bool IsCreatief
        {
            get;
        }

        public abstract bool KanRijmen
        {
            get;
        }

        public abstract bool SnaptComputers
        {
            get;
        }

        public Piet()
        {

        }

        public override string ToString()
        {
            return "return";
        }
    }
}
