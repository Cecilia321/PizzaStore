using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Topping
    {
        string toppingNavn;
        double pris;

        public Topping(string ToppingNavn, double Pris)
        {
            this.ToppingNavn = ToppingNavn;
            this.Pris = Pris;    
        }

        public string ToppingNavn { get => toppingNavn; set => toppingNavn = value; }
        public double Pris { get => pris; set => pris = value; }

        public override string ToString()
        {
            return toppingNavn.PadRight(82) + Pris + "kr.";
        }
    }
}
