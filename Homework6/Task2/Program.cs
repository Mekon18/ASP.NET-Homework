using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flower> bouquet = new List<Flower>
            {
                new Rose(),
                new Tulip(),
                new Tulip(),
                new Carnation(),
                new Carnation(),
                new Flower(15)
            };


            uint PriceSum = 0;

            foreach (var flower in bouquet)
            {
                PriceSum += flower.GetPrice();
            }
            System.Console.WriteLine(PriceSum);
        }
    }
}
