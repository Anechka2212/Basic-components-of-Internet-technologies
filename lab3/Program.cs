using System;
using System.Collections.Generic;
using System.Collections;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2), 3) Test");

            Circle circle = new Circle(13);
            circle.Print();

            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.Print();

            Square square = new Square(7);
            square.Print();

            Console.WriteLine("4) ArrayList");
            ArrayList array = new ArrayList();            array.Add(circle);
            array.Add(rectangle);
            array.Add(square);
            foreach (var x in array)
                Console.WriteLine(x);

            Console.WriteLine("Sort: ");
            array.Sort();
            foreach (var x in array)
                Console.WriteLine(x);

            Console.WriteLine("5) List<Figure>");
            List<Figure> list = new List<Figure>();

            list.Add(circle);
            list.Add(rectangle);
            list.Add(square);
            foreach (var x in list)
                Console.WriteLine(x);

            Console.WriteLine("Sort: ");
            list.Sort();
            foreach (var x in list)
                Console.WriteLine(x);

            Console.WriteLine("6) Matrix");
            Matrix<Figure> matrix = new Matrix<Figure>(2, 2, 2, rectangle);
            Console.WriteLine(matrix.ToString());

            Console.WriteLine("7), 8) SimpleList");
            SimpleList<Figure> simple = new SimpleList<Figure>();

            simple.Add(circle);
            simple.Add(rectangle);
            simple.Add(square);
            foreach (var x in simple)
                Console.WriteLine(x);

            simple.Sort();
            Console.WriteLine("Sort");
            foreach (var x in simple)
                Console.WriteLine(x);

            Console.WriteLine("7), 8) SimpleStack");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(circle);
            stack.Push(rectangle);
            stack.Push(square);

            while (stack.Count > 0)
            {
                Figure figure = stack.Pop();
                Console.WriteLine(figure);
            }

            Console.ReadKey();
        }
    }
}
