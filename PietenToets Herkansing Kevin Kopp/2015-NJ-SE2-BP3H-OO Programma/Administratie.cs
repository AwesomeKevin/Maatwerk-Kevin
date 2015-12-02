using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

            Provincie provincie = new Provincie("Drenthe");
            Thuisbasis = new Gemeente("Meppel", provincie, 5827, 428, 3279);
        }

        public void Importeer()
        {
            
        }

        public void VoegToe(string gemeente, string provincie, int aantalKinderen, int x, int y)
        {

        }

        public Provincie ZoekOpNaam(string naam)
        {
            Provincie p = new Provincie("Gelderland");
            return p;
        }

        public List<Piet> StelPosseSamen(Gemeente gemeente, List<CadeauType> cadeauTypes)
        {
            List<Piet> pieten = new List<Piet>();

            return pieten;
        }
    }
}
