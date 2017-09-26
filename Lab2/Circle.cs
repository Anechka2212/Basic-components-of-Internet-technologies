using System;

namespace Laba2
{
    class Circle : Figure, IPrint
    {
        /// <summary>
        /// Ширина
        /// </summary>
        double radius;
        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Circle(double pr)
        {
            radius = pr;
            Type = "Circle";
        }
        public override double Area()
        {
            double Result = Math.PI * radius * radius;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

}
