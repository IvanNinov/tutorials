using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumF = 0;
            int sumT = 0;
            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                sumF += newNum;
            }
            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                sumT += newNum;
            }
            if (sumF == sumT)
            {
                Console.WriteLine($"Yes, sum = {sumF}");

            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumF - sumT)}");
            }
            
        }
    }
}
