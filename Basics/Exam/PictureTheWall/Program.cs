using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureTheWall
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthHole = int.Parse(Console.ReadLine());
            int lengthHole = int.Parse(Console.ReadLine());
            int sidePicture = int.Parse(Console.ReadLine());
            int numberPicture = int.Parse(Console.ReadLine());


            int areaH = widthHole * lengthHole;
            int areaP = (sidePicture * sidePicture) * numberPicture;
            int discrepancy = areaH - areaP; 
            if (areaH > areaP)
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {Math.Abs(discrepancy)} bigger than pictures area.");

            }
            else
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {Math.Abs(discrepancy)} bigger than hole area.");

            }

        }
    }
}
