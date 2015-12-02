using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public class Administratie
    {
        public Gemeente Thuisbasis { get; set; }
        public List<Provincie> provincies;

        public Administratie()
        {
            provincies = new List<Provincie>();
        }

        public void Importeer()
        {

        }

        public void VoegToe(string gemeente, string provincie, int aantalKinderen, int x, int y)
        {

        }

        public Provincie ZoekOpNaam(string naam)
        {
            Provincie p = new Provincie("Bladel");
            return p;
        }
    }
}
