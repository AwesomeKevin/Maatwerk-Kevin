using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoT_RPG
{
    public class Land
    {
        //Properties
        public string Naam { get; set; }
        public List<Personage> personages;

        //Constructors
        public Land(string naam)
        {
            Naam = naam;
            personages = new List<Personage>();
        }
    }
}
