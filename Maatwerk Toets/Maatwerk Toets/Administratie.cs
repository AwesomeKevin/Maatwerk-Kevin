using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maatwerk_Toets
{
    public class Administratie : IComparable<Administratie>
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

        public List<IInkomsten> Overzicht(DateTime van, DateTime tot)
        {
            return null;
            //Ik ben op dit punt van de toets gestopt, omdat ik niet wist hoe ik verder moest werken.
            //De overige opdrachten begrijp ik gewoon niet goed genoeg, maar ik heb nu wel een duidelijk beeld wat mijn ontwikkelpunten zijn.
        }
    }
}
