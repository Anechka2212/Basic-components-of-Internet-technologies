using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            Circle circle = new Circle(13);
            circle.Print();

            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.Print();

            Square square = new Square(7);
            square.Print();

            Console.ReadKey();
        }
    }
}
