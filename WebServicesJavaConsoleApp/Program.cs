using System;
using WeirdService;

namespace WebServicesJavaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var wh = new WorldHelloClient();

            var products = wh.ProductsAsync().Result.@return;

            foreach (var product in products)
            {
                Console.WriteLine("Otrzymano produkt {0}, o opisie {1} i cenie {2}", product.nazwa, product.opis, product.cena);
            }

            Console.ReadLine();

        }
    }
}
