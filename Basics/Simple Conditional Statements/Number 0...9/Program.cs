using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbers=
               new Dictionary<string, int>();
            numbers.Add("zero", 0);
            numbers.Add("one", 1);
            numbers.Add("two", 2);
            numbers.Add("three", 3);
            numbers.Add("four", 4);
            numbers.Add("five", 5);
            numbers.Add("six", 6);
            numbers.Add("seven", 7);
            numbers.Add("eight", 8);
            numbers.Add("nine", 9);

            var number = float.Parse(Console.ReadLine());

            foreach (KeyValuePair<string, int> pair in numbers)
            {
                if (number == pair.Value)
                {
                    Console.WriteLine("{0}",pair.Key);
                }
            }

        }
    }
}
