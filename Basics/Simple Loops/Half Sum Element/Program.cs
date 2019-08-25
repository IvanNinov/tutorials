using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int big = 0;
            int sum = 0;
            double res = 0.0;
            for (int i = 0; i < n; i++)
            {

                int newNum = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    big = newNum;
                }
 
                if (newNum > big)
                {
                    big = newNum;
                }
                    sum += newNum;               
            }
            res = Math.Abs(big - sum);
            if (big == res )
            {
                Console.WriteLine($"Yes Sum = {big}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(big - res)}");

            }
        }
    }
}
