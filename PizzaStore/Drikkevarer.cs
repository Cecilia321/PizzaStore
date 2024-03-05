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
            drikkevarepris = Drikkevarepris;
        }

        public override string ToString()
        {
            return navn.PadRight(82) + drikkevarepris + "Kr.";
        }
        public double Drikkevarepris
        {
            get { return drikkevarepris; }
        }
    }
}
