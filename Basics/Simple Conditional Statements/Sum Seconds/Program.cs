using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            int totalsec = firstNum + second + third;
            int min = totalsec / 60;
            int sec = totalsec % 60;
            Console.WriteLine($"{min}:{sec:d2}");
        }
    }
}
