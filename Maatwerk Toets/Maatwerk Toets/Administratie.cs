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
        public List<Verkoop> Verkopen { get; private set; }
        public List<Verhuur> Verhuringen { get; private set; }

        //Constructor
        public Administratie()
        {
            Verkopen = new List<Verkoop>();
            Verhuringen = new List<Verhuur>();
        }

        //Methodes
        public bool VoegToe(Verhuur verhuur)
        {
            Verhuringen.Add(verhuur);
            return true;
        }

        public bool VoegToe(Verkoop verkoop)
        {
            Verkopen.Add(verkoop);
            return true;
        }

        public List<IInkomsten> Overzicht(DateTime van, DateTime tot)
        {
            List<IInkomsten> overzicht = new List<IInkomsten>();
            foreach (Verkoop a in Verkopen)
            {
                if (a.Tijdstip > van && a.Tijdstip < tot)
                {
                    overzicht.Add((IInkomsten)a);
                }
            }
            foreach (Verhuur a in Verhuringen)
            {
                if (a.Tijdstip > van && a.Tijdstip < tot)
                {
                    overzicht.Add((IInkomsten)a);
                }
            }

            overzicht.Sort();
            return overzicht;
        }

        public List<IInkomsten> Overzicht(BTWTarief tarief)
        {
            List<IInkomsten> overzicht = new List<IInkomsten>();

            if (tarief == BTWTarief.Ongespecificeerd)
            {
                overzicht.AddRange(Verkopen);
            }
            else if (tarief != BTWTarief.Ongespecificeerd)
            {
                foreach (Verkoop a in Verkopen)
                {
                    if (a.BTWTarief == tarief)
                    {
                        overzicht.Add(a);
                    }
                }
            }

            if (tarief == BTWTarief.Ongespecificeerd)
            {
                overzicht.AddRange(Verhuringen);
            }
            else if (tarief != BTWTarief.Ongespecificeerd)
            {
                foreach (Verhuur v in Verhuringen)
                {
                    if (v.BTWTarief == tarief)
                    {
                        overzicht.Add(v);
                    }
                }
            }

            overzicht.Sort();
            return overzicht;
        }
    }
}
