using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            char k = char.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());

            int x1 = (int)n + n1;
            int x2 = (int)m + m1;
            int x3 = (int)k + k1;


            char f = (char)x1;
            char s = (char)x2;
            char t = (char)x3;

            if (f == '@' && s == '@' && t == '@')
            {
                Console.WriteLine($"{f}{s}{t}");
                Console.WriteLine($"!!! YOU LOSE EVERYTHING !!!");
            }
            else if (f == '7' && s == '7' && t == '7')
            {
                Console.WriteLine($"{f}{s}{t}");
                Console.WriteLine($"*** JACKPOT ***");
            }
            else
            {
                Console.WriteLine($"{f}{s}{t}");
            }

        }
    }
}
