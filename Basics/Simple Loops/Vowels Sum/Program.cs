using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToLower();
            string c = "aeiou";
            int sum = 0;

            for (int i = 0; i <= str.Length - 1; i++)
            {
                for (int j = 0; j <= c.Length - 1; j++)
                {
                    if (str[i] == c[j])
                    {
                        sum += j + 1; 
                    }
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
