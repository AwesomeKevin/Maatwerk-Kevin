using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Administratie
    {
        //Properties
        public List<Verkoop> verkopen;
        public List<Verhuur> verhuren;

        //Constructor
        public Administratie()
        {
            verkopen = new List<Verkoop>();
            verhuren = new List<Verhuur>();
        }

        //Methodes
        public void VoegToe(Verhuur verhuur)
        {

        }

        public void VoegToe(Verkoop verkoop)
        {

        }
    }
}
