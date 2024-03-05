using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Menu
    {
        private double totalPris;
        private Pizza pizzapris;
        private Drikkevarer drikkevarerpris;
        private Kunde kundenavn;
        private Topping topping;


        public double TotalPris { get => totalPris; set => totalPris = value; }
        internal Pizza Pizzapris { get => pizzapris; set => pizzapris = value; }
        internal Drikkevarer Drikkevarerpris { get => drikkevarerpris; set => drikkevarerpris = value; }


            Pizza pizza1 = new Pizza("Nr. 1", "Margeritha", "Tomat og ost", 69);
            Pizza pizza2 = new Pizza("Nr. 2", "Big Mamma", "Tomat, gorgonzola, reje, asparges og parma skinke", 90);
            Pizza pizza3 = new Pizza("Nr. 3", "Italiana", "Tomat, ost, løg og kødsovs", 75);

            Drikkevarer Drikkevare1 = new Drikkevarer("Cola", 24.50);
            Drikkevarer Drikkevare2 = new Drikkevarer("Sprite", 22.50);
            Drikkevarer Drikkevare3 = new Drikkevarer("Fanta", 25);

            Topping Topping1 = new Topping("ekstra ost", 7);
            Topping Topping2 = new Topping("parma skinke", 14);
            Topping Topping3 = new Topping("løg", 5);
        

        public override string ToString()
        {
            return Environment.NewLine + "Id:".PadRight(10) + "Menu:".PadRight(72) + "Pris:" + Environment.NewLine + pizza1.ToString() + Environment.NewLine 
                + pizza2.ToString() + Environment.NewLine + pizza3.ToString()
                + Environment.NewLine + Environment.NewLine + "Drikkevare:" + Environment.NewLine + Drikkevare1.ToString() 
                + Environment.NewLine + Drikkevare2 + Environment.NewLine + Drikkevare3 + Environment.NewLine + Environment.NewLine + "Ekstra tilvalg:" + Environment.NewLine + Topping1 + Environment.NewLine + Topping2 
                + Environment.NewLine + Topping3;
           
        }





    public Pizza Pizza1
        {
            get { return pizza1; }
        }

        public Pizza Pizza2
        {
            get { return pizza2; } 
        }

        public Pizza Pizza3
        {
            get { return pizza3; }
        }



        public Drikkevarer drikkevarer1
        {
            get { return Drikkevare1; }
        }

        public Drikkevarer drikkevarer2
        {
            get { return Drikkevare2; }
        }

        public Drikkevarer drikkevarer3
        {
            get { return Drikkevare3; }
        }

        public Topping topping1 
        {
            get { return Topping1; }
        }

        public Topping topping2
        {
            get { return Topping2; }
        }

        public Topping topping3
        {
            get { return Topping3; }
        }







    }










































}
    


