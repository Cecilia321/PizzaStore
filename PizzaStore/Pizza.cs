using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        string navn;
        string topping;
        double pizzapris;
        string id;


        public Pizza(string Id, string Navn, string Topping, double Pizzapris)
        {
            
            navn = Navn;
            topping = Topping;
            pizzapris = Pizzapris;
            id = Id;
        }

        public double Pizzapris { get => pizzapris; set => pizzapris = value; }

        public override string ToString()
        {
            return id.PadRight(10) + navn.PadRight(10) + ": " + topping.PadRight(60) + Pizzapris + "kr.";
        }

       

    }   
}
