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
        public List<Verhuur> verhuringen;

        //Constructor
        public Administratie()
        {
            verkopen = new List<Verkoop>();
            verhuringen = new List<Verhuur>();
        }

        //Methodes
        public bool VoegToe(Verhuur verhuur)
        {
            verhuringen.Add(verhuur);
            return true;
        }

        public bool VoegToe(Verkoop verkoop)
        {
            verkopen.Add(verkoop);
            return true;
        }
    }
}
