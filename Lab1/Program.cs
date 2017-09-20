using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's solve!");
            Console.WriteLine("Enter the coefficient A!");
            double A = check();
            Console.WriteLine("Enter the coefficient B!");
            double B = check();
            Console.WriteLine("Enter the coefficient C!");
            double C = check();

            count(A, B, C);

            Console.ReadKey(); //system_pause
        }
        static double check()
        {
            double coefficient;
            string input;
            bool test = true;
            do
            {
                input = Console.ReadLine();
                test = double.TryParse(input, out coefficient);
                if (!test) Console.WriteLine("Try again!");
            } while (!test);
            return coefficient;
        }
        static void count(double a, double b, double c)
        {
            double dis = b * b - 4 * a * c;
            if(dis < 0)
            {
                Console.WriteLine("Oooops! No roots :c");
                return;
            }
            if(dis == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("We have one root: " + x);
                return;
            }
            if (dis > 0)
            {
                double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("We have two root: " + x1 + " and " + x2);
                return;
            }
        }
    }
}
