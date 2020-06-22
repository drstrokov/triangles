using System;

namespace _6._05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double x = (a * a);
            double x1 = (b * b);
            double x2 = (c * c);
            double x3 = Math.Cos( - 2 * b * c);
            double x4 = (x1 + x2)/ x3;

            if (x2 == x + x1 && x2 > 0) 
            {
                Console.WriteLine("right");
            }
            else if (x4 > 0)
            {
                Console.WriteLine("acute");
            }
            else if (x4 < 0)
            {
                Console.WriteLine("obtuse");
            }
            else 
            {
                Console.WriteLine("impossible");
            }










        }

    }
                 
}


