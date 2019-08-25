using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dif = 0;
            int oldNum = 0;
            int min = 1000000000;
            int max = -1000000000;
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int newNum = int.Parse(Console.ReadLine());
                        number += newNum;           
                }
                if (i != 0)
                {
                    dif = Math.Abs(number - oldNum);
                    if (dif > max)
                    {
                        max = dif;
                    }
                    if (dif < min)
                    {
                        min = dif;
                    }
                }
                oldNum = number;
                number = 0;
            }

            if (dif == 0)
            {
                Console.WriteLine($"Yes, value={oldNum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={max}");

            }
        }
    }
}
