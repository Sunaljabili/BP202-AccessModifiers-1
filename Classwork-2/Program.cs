using System;

namespace Classwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("kartof");
            product.Price = 0.5;
            product.Count = 3;
            
            product.Sell();
            product.Sell();
            product.Sell();
            product.Sell();
            Console.WriteLine($"qazanilan gelir: {product.TotalInCome}");

            Milk milk = new Milk("milla");



        }
    }
}
