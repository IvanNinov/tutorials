using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumF = 0;
            double sumT = 0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;


            if (n == 0)
            {
                Console.WriteLine($"OddSum={sumF},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={sumT},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No,");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                double newNum = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {

                    if (newNum > oddMax)
                    {
                        oddMax = newNum;
                    }
                    if (newNum < oddMin)
                    {
                        oddMin = newNum;
                    }

                    sumF += newNum;
                }
                else
                {
                    if (newNum > evenMax)
                    {
                        evenMax = newNum;
                    }
                    if (newNum < evenMin)
                    {
                        evenMin = newNum;
                    }

                    sumT += newNum;
                }

            }


            if (oddMax == -1000000000.0 || oddMin == 1000000000.0)
            {
                Console.WriteLine($"OddSum={sumF},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");

            }
            else
            {
                Console.WriteLine($"OddSum={sumF},");
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
            }

            if (evenMax == -1000000000.0 || evenMin == 1000000000.0)
            {
                Console.WriteLine($"EvenSum={sumT},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No,");
            }
            else
            {
                Console.WriteLine($"EvenSum={sumT},");
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax},");
            }


        }
    }
}
