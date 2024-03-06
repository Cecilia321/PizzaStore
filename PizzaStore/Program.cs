using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Ordre O1 = new Ordre();
            string menuvalg = "";
            string drikkevalg = "";
            string toppingvalg = "";
            double totalpris = 0;
            string kundenavn;
            


            Console.WriteLine("Velkommen til Big Mammas pizzaria, vil du se menuen?");
            string response = Console.ReadLine();

            //når vi er her inde så har brugeren sagt ja til at bestille
            if (response.ToLower().Equals("ja"))
            {
                Console.WriteLine(menu);
                Console.WriteLine(Environment.NewLine + "Hvilken pizza kunne du tænke dig at bestille?");
                response = Console.ReadLine();


                if (response.ToLower().Equals("1"))
                {
                    menuvalg = menu.Pizza1.ToString();
                    totalpris += menu.Pizza1.Pizzapris;
                    Console.WriteLine(Environment.NewLine + "Du har valgt: " + Environment.NewLine + menu.Pizza1);
                    Console.WriteLine(Environment.NewLine + "Ønsker du at ilføje ekstra topping?");
                    response = Console.ReadLine();
                }
                else if (response.ToLower().Equals("2"))
                {
                    menuvalg = menu.Pizza2.ToString();
                    totalpris += menu.Pizza2.Pizzapris;
                    Console.WriteLine(Environment.NewLine + "Du har valgt: " + Environment.NewLine + menu.Pizza2);
                    Console.WriteLine(Environment.NewLine + "Ønsker du at ilføje ekstra topping?");
                    response = Console.ReadLine();
                }
                else if (response.ToLower().Equals("3"))
                {
                    menuvalg = menu.Pizza3.ToString();
                    totalpris += menu.Pizza3.Pizzapris;
                    Console.WriteLine(Environment.NewLine + "Du har valgt: " + Environment.NewLine + menu.Pizza3);
                    Console.WriteLine(Environment.NewLine + "Ønsker du at ilføje ekstra topping?");
                    response = Console.ReadLine();

                }
                else
                {
                    Environment.Exit(0);
                }

                //tilføj topping
                if (response.ToLower().Equals("ekstra ost"))
                {
                    toppingvalg = menu.topping1.ToString();
                    totalpris += menu.topping1.Pris;
                    Console.WriteLine(Environment.NewLine + "Du har nu valgt: " + Environment.NewLine + menuvalg + Environment.NewLine + menu.topping1 + Environment.NewLine + "I alt".PadRight(82) + totalpris + "kr.");
                    Console.WriteLine(Environment.NewLine + "Ønsker du at ilføje drikkevare?");
                    response = Console.ReadLine();

                }
                else if (response.ToLower().Equals("parma skinke"))
                {
                    toppingvalg = menu.topping2.ToString();
                    totalpris += menu.topping2.Pris;
                    Console.WriteLine(Environment.NewLine + "Du har valgt: " + Environment.NewLine + menuvalg + Environment.NewLine + menu.topping2 + Environment.NewLine + "I alt".PadRight(82) + totalpris + "kr.");
                    Console.WriteLine(Environment.NewLine + "Ønsker du at ilføje drikkevare?");
                    response = Console.ReadLine();
                }

                else if (response.ToLower().Equals("løg"))
                {
                    toppingvalg = menu.topping3.ToString();
                    totalpris += menu.topping3.Pris;
                    Console.WriteLine(Environment.NewLine + "Du har valgt: " + Environment.NewLine + menuvalg + Environment.NewLine + menu.topping3 + Environment.NewLine + "I alt".PadRight(82) + totalpris + "kr.");
                    Console.WriteLine(Environment.NewLine + "Ønsker du at ilføje drikkevare?");
                    response = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Jeg ønsker ingen toppings");
                }

                    //for drikkevare
                    if (response.ToLower().Equals("cola"))
                    {
                        drikkevalg = menu.drikkevarer1.ToString();
                        totalpris += menu.drikkevarer1.Drikkevarepris;
                        Console.WriteLine(Environment.NewLine + "Du har nu valgt: " + Environment.NewLine + menuvalg + Environment.NewLine + toppingvalg + Environment.NewLine + menu.drikkevarer1 + Environment.NewLine + "I alt".PadRight(82) + totalpris + "kr.");
                        Console.WriteLine(Environment.NewLine + "Skriv dit navn for at bekræfte din ordre ");

                    }
                    else if (response.ToLower().Equals("sprite"))
                    {
                        drikkevalg = menu.drikkevarer2.ToString();
                        totalpris += menu.drikkevarer2.Drikkevarepris;
                        Console.WriteLine(Environment.NewLine + "Du har nu valgt: " + Environment.NewLine + menuvalg + Environment.NewLine + toppingvalg + Environment.NewLine + menu.drikkevarer2 + Environment.NewLine + "I alt".PadRight(82) + totalpris + "kr.");
                        Console.WriteLine(Environment.NewLine + "Skriv dit navn for at bekræfte din ordre ");

                    }
                    else if (response.ToLower().Equals("fanta"))
                    {
                        drikkevalg = menu.drikkevarer3.ToString();
                        totalpris += menu.drikkevarer3.Drikkevarepris;
                        Console.WriteLine(Environment.NewLine + "Du har nu valgt: " + Environment.NewLine + menuvalg  + Environment.NewLine + toppingvalg + Environment.NewLine + menu.drikkevarer3 + Environment.NewLine + "I alt".PadRight(82) + totalpris + "kr.");

                        Console.WriteLine(Environment.NewLine + "Skriv dit navn for at bekræfte din ordre ");
                    }
                    else
                    {
                        Console.WriteLine("Jeg ønsker ingen drikkevare." + Environment.NewLine + "Skriv dit navn for at bekræfte din ordre");
                    }

                    //her skriver kunden sit navn og får en ordre bekræftelse 
                    kundenavn = Console.ReadLine();
                    if (kundenavn.ToLower() != (""))
                    {
                        Console.Clear();
                        kundenavn = kundenavn;
                        Console.WriteLine(Environment.NewLine + "Tak for din ordre " + kundenavn + Environment.NewLine + "Du har d." + O1.ToString() + " Bestilt følgende:"
                            + Environment.NewLine + menuvalg + Environment.NewLine + toppingvalg + Environment.NewLine + drikkevalg + Environment.NewLine + "I alt".PadRight(82) + totalpris + "kr." + Environment.NewLine
                            + "Din mad er klar til at blive hentet om ca. 10 minutter.");
                        response = Console.ReadLine();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }


                }
            }
        }
    }




