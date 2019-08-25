using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());

            double moneyLeft = 0.0;
            double fullPrice = 0.0;
            int count = 0;
            if (n > 7)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
                return;
            }


            for (int i = 0; i < n; i++)
            {
                var present = Console.ReadLine();
                if (present == "ak47")
                {
                    fullPrice += 2700;
                }
                else if (present == "awp")
                {
                    fullPrice += 4750;

                }
                else if (present == "sg553")
                {
                    fullPrice += 3500;

                }
                else if (present == "grenade")
                {
                    fullPrice += 300;

                }
                else if (present == "flash")
                {
                    fullPrice += 250;

                }
                else if (present == "glock")
                {
                    fullPrice += 500;

                }
                else if (present == "bazooka")
                {
                    fullPrice += 5600;

                }
                count += 1;
            }
            if (money >= fullPrice)
            {
                moneyLeft = money - fullPrice;
                Console.WriteLine($"You bought all {count} items! Get to work and defeat the bomb!");
            }
            else
            {
                moneyLeft = fullPrice - money;
                Console.WriteLine($"Not enough money! You need {moneyLeft} more money.");
            }
        }
    }
}
