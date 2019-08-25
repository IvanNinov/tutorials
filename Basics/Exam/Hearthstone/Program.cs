using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int restTime = int.Parse(Console.ReadLine());
            double priceDeck = double.Parse(Console.ReadLine());
            double adventure = double.Parse(Console.ReadLine());
            double coffee = double.Parse(Console.ReadLine());
            double sum = 0.0;

            int buyCardTime = 6;
            int buyAdventures = 4;
            int timeSpend = restTime - 5;
            timeSpend = timeSpend - 10;


            double cardPrice =3.0 * priceDeck;
            double advePrice = 2.0 * adventure;
            sum = cardPrice + advePrice + coffee;

            Console.WriteLine($"{sum:f2}");
            Console.WriteLine($"{timeSpend}");




        }
    }
}
