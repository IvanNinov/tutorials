using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int big = 0;
            int small = 0;
            for (int i = 0; i < n; i++)
            {

                int newNum = int.Parse(Console.ReadLine());
                if (newNum <= small)
                {
                    small = newNum;
                }
                if (i == 0)
                {
                    small = newNum;
                }
            }
            Console.WriteLine($"{small}");
        }
    }
}
