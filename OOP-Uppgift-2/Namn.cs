using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift_2
{
    internal class Namn
    {
        private string förnamn;
        private string efternamn;

        public string SetNamn
        {
            get { return förnamn + " " + efternamn; }
            set { förnamn = value.Split(" ")[0]; efternamn = value.Split(" ")[1]; }
        }
    }
}
