using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double  metric =  double.Parse(Console.ReadLine());
            double sum = 1.0;
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from == "mm")
            {
                sum = metric / 1000;
            }
            else if (from == "cm")
            {
                sum = metric / 100;
            }
            else if (from == "mi")
            {
                sum = metric / 0.000621371192;
            }
            else if (from == "in")
            {
                sum = metric / 39.3700787;
            }
            else if (from == "km")
            {
                sum = metric / 0.001;
            }
            else if (from == "ft")
            {
                sum = metric / 3.2808399;
            }
            else if (from == "yd")
            {
                sum = metric / 1.0936133;
            }
            else if (from == "m")
            {
                sum = metric;
            }

            if (to == "mm")
            {
                metric = sum * 1000;
            }
            else if (to == "cm")
            {
                metric = sum * 100;
            }
            else if (to == "mi")
            {
                metric = sum * 0.000621371192;
            }
            else if (to == "in")
            {
                metric = sum * 39.3700787;
            }
            else if (to == "km")
            {
                metric = sum * 0.001;
            }
            else if (to == "ft")
            {
                metric = sum * 3.2808399;
            }
            else if (to == "yd")
            {
                metric = sum * 1.0936133;
            }
            else if (to == "m")
            {
                metric = sum;
            }

            Console.WriteLine($"{metric}");

        }
    }
}
