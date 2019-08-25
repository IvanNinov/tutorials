namespace Slord
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //6irina (2n)+1
            //2n/2
            //n + 3    (__ Soft Uni ___)
            // (n+3)-7 Soft (____)Uni
          
            int n = int.Parse(Console.ReadLine());
            int num = n + 3;
            string type = "/^\\";
            int c = 3;
            int b = 0;
            string f1 = new string('#', n - 1);
            Console.WriteLine("{0}{1}{0}", f1, type);


            for (int i = 1; i <= n / 2; i++)
            {             
                    string n1 = new string('#', n - i - 1);
                    string n2 = new string(' ', c);
                    Console.WriteLine("{0}.{1}.{0}", n1,n2);
                    c += 2;
                b = n - i - 1;
                
            }

            for (int i = 1; i <= 4; i++)
            {
                string n1 = new string('#', b);
                string n2 = new string(' ', n/2);
                if (i == 1)
                {
                    Console.WriteLine("{0}|{1}S{1}|{0}",n1,n2);
                }
                else if (i == 2)
                {
                    Console.WriteLine("{0}|{1}O{1}|{0}", n1, n2);

                }
                else if (i == 3)
                {
                    Console.WriteLine("{0}|{1}F{1}|{0}", n1, n2);

                }
                else if (i == 4)
                {
                    Console.WriteLine("{0}|{1}T{1}|{0}", n1, n2);

                }

            }
            int number = ((2 * n) + 1) - ((2 * b) + 4) - 2;
            if (n % 2 == 0)
            {
                number -= 1;
            }

            for (int i = 1; i <=  number; i++)
            {
                string n1 = new string('#', b);
                string n2 = new string(' ', n / 2);
                Console.WriteLine("{0}|{1} {1}|{0}", n1, n2);

            }

            for (int i = 1; i <= 3; i++)
            {
                string n1 = new string('#', b);
                string n2 = new string(' ', n / 2);

                if (i == 1)
                {
                    Console.WriteLine("{0}|{1}U{1}|{0}", n1, n2);
                }
                else if (i == 2)
                {
                    Console.WriteLine("{0}|{1}N{1}|{0}", n1, n2);
                }
                else if (i == 3)
                {
                    Console.WriteLine("{0}|{1}I{1}|{0}", n1, n2);
                }
            }
            //(2*n) + 1
            //(n/2) + 1
            string handle = new string('=',(2 * n - 1));
            Console.WriteLine("@{0}@",handle);

            for (int i = 1; i <= n/2; i++)
            {
                string n1 = new string('#', b + 2);
                string n2 = new string(' ', ((2 * n)+ 1) - ((2 * b) + 4) - 2 );
                Console.WriteLine("{0}|{1}|{0}",n1,n2);
            }
            string n3 = new string('.', ((2 * n) + 1) - ((2 * b) + 4) - 2);
            string n4 = new string('#',b + 2);
            Console.WriteLine("{0}\\{1}/{0}",n4,n3);

        }
    }
}
