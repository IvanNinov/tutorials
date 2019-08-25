using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int minutes = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());

            if((sec >= 45)&&(sec <= 60 ))
            {
                minutes += 1;
                sec += 15;
                sec -= 60;
            }
            else
            {
                sec += 15;
            }
           if(minutes == 24)
            {
                minutes = 0;
            }
            Console.WriteLine("{0}:{1:d2}",minutes,sec);
        }
    }
}
