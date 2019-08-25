using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            double result = 0.0;
            if (str == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                result = num1 * num1;
            }
            else if (str == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                result = num1 * num2;
            }
            else if (str == "circle")
            {
                double num1 = double.Parse(Console.ReadLine());
                result = (num1 * num1) * Math.PI ;
            }
            else if (str == "triangle")
            {
                double num1 = Math.Round(double.Parse(Console.ReadLine()), 3);
                double num2 = Math.Round(double.Parse(Console.ReadLine()),3);
                result = (num1 * num2)/2;

            }
            result = Math.Round(result, 3);
            Console.WriteLine($"{result}");
        }
    }
}
