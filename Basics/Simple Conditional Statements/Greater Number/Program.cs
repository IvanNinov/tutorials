using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            if (firstNum >= secondNum)
            {
                Console.Write(firstNum);
            }
            else if (secondNum >= firstNum)
            {
                Console.Write(secondNum);
            }

        }
    }
}

