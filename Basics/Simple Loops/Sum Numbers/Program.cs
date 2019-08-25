using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                sum += newNum;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
