using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int seccond = int.Parse(Console.ReadLine());
            int left = int.Parse(Console.ReadLine());
            int right = int.Parse(Console.ReadLine());


            int fend = (first + left);
            int send = (seccond + right);

            //Console.WriteLine($"{fStart}  {send}");
            int ctrF;
            int ctrS;
            bool sTrue;
            bool fTrue;

            for (int i = first; i <= fend; i++)
            {               
                    ctrF = 0;
                    fTrue = false;

                for (int s = 2; s <= i/2; s++)
                    {
                        if (i % s == 0)
                        {
                            ctrF++;
                            break;
                        }
                    }
                if (ctrF == 0)
                {
                    fTrue = true;
                    
                }           
                for (int j = seccond; j <= send; j++)
                {
                    ctrS = 0;
                    sTrue = false;
                    for (int s = 2; s <= j / 2; s++)
                    {
                        if (j % s == 0)
                        {
                            ctrS++;
                            break;
                        }
                    }
                    if (ctrS == 0)
                    {
                        sTrue = true;

                    }
                    if (fTrue && sTrue)
                    {
                        Console.WriteLine($"{i}{j} ");
                    }
                }
                
            }
            
        }
            
    }
}
