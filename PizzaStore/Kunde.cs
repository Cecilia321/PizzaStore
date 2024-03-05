using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Kunde
    {
        string kundenavn;
        int telefon;

        public Kunde(string Kundenavn, int Telefon)
        {
            kundenavn = Kundenavn;
            telefon = Telefon;
        }

        public override string ToString()
        {
            return "Navn:".PadRight(10) + kundenavn.PadRight(20) + "Telefon:" + telefon;
        }

        
       
    }
}
