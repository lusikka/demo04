using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer beer1 = new Beer();
            beer1.Vol = 4.7;
            beer1.Price = 4.50;
            beer1.BeerType = "Dark Lager";
            Beer beer2 = new Beer();
            beer2.Vol = 6.3;
            beer2.Price = 6.50;
            beer2.BeerType = "Premium IPA";
            Cider cider1 = new Cider();
            cider1.Vol = 4.4;
            cider1.Price = 5.50;
            cider1.CiderType = "Dry Apple Cider";
            Cider cider2 = new Cider();
            cider2.Vol = 4.5;
            cider2.Price = 6.00;
            cider2.CiderType = "Dolce Pear Cider";
            Console.WriteLine("You are at a bar. You check the menu:");
            for (int i = 0; i <= 3; i++)
            {
                Console.Write("Item number " + (i + 1) + " -");
                if (i == 0)
                {
                    Console.WriteLine(beer1.ToString());
                }
                else if (i == 1)
                {
                    Console.WriteLine(beer2.ToString());
                }
                else if (i == 2)
                {
                    Console.WriteLine(cider1.ToString());
                }
                else if (i == 3)
                {
                    Console.WriteLine(cider2.ToString());
                }
            }
        }
    }
}
