using System;

namespace Laba2
{
    class Rectangle : Figure, IPrint
    {
        /// <summary>
        /// Высота
        /// </summary>
        double height;
        /// <summary>
        /// Ширина
        /// </summary>
        double width;
        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public Rectangle(double ph, double pw)
        {
            height = ph;
            width = pw;
            Type = "Rectangle";
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = width * height;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
