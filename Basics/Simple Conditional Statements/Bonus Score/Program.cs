using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double result = points;
            double bonus = 0;

            if (points <= 100)
            {
                bonus = 5;
                result += bonus;
            }
            else if ((points > 100) && (points <= 1000))
            {
                bonus = points * 0.2;
                result += bonus;
            }
            else if (points > 1000)
            {
                bonus = points * 0.1;
                result += bonus;
            }

            if (points % 2 == 0 )
            {
                bonus += 1;
                result += 1;
            }
            else if (points % 5 == 0)
            {
                bonus += 2;
                result += 2;
            }
            Console.WriteLine("{0}", bonus);
            Console.WriteLine("{0}",result);
        }
    }
}
