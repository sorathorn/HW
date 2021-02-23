using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string O;
            int pass, d1, d2, d3, d4, d5, d6;
            Console.Write("input password: ");
            pass = int.Parse(Console.ReadLine());
            d1 = pass % 10;
            d2 = (pass % 100) / 10;
            d3 = (pass % 1000) / 100;
            d4 = (pass % 10000) / 1000;
            d5 = (pass % 100000) / 10000;
            d6 = (pass % 1000000) / 100000;


            Console.Write("input organization: ");
            O = Console.ReadLine();

            bool A;

            if (O == "CIA")
            {
                A = (d1 % 3 == 0 && d2 != (1 & 3 & 5) && d4 >= 6 && d4 != 8);
                    Console.WriteLine("Your pass is {0} ", A);
            }
            if (O == "FBI")
            {
                A = (d6 >= 4 && d6 <= 7 && d3 % 2 == 0 && d3 != 6 && d5 % 2 != 0);
                    Console.WriteLine("Your pass is {0} ", A);
            }
            if (O == "NSA")
            {
                A = (30 % d1 == 0 && d3 % 3 == 0 && d3 % 2 != 0 && d1 == 7 || d2 == 7 || d3 == 7 || d4 == 7 || d5 == 7 || d6 == 7);
                    Console.WriteLine("Your pass is {0} ", A);
            }
            else
            {
                A = false;
                Console.WriteLine("Your pass is {0} ", A);
            } 

              
              
            


            
            
        }
    }
}
