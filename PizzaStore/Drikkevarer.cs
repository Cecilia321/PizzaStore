using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Drikkevarer
    {
        string navn;
        double drikkevarepris;

        public Drikkevarer(string Navn, double Drikkevarepris)
        {
            navn = Navn;
            Drikkevarepris1 = Drikkevarepris;
        }

        public override string ToString()
        {
            return navn.PadRight(82) + Drikkevarepris1 + "Kr.";
        }

        public double Drikkevarepris
        {
            get { return Drikkevarepris1; }
        }

        public double Drikkevarepris1 { get => drikkevarepris; set => drikkevarepris = value; }
    }
}
