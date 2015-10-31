using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoT_RPG
{
    public class Item
    {
        //Properties
        public string Naam { get; set; }
        public string Eigenschap { get; set; }

        //Constructors
        public Item(string naam, string eigenschap)
        {
            Naam = naam;
            Eigenschap = eigenschap;
        }
    }
}
