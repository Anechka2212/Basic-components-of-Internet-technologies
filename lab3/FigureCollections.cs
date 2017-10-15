using System;

namespace Laba2
{
        abstract class Figure : IComparable
        {
            /// <summary>
            /// Тип фигуры
            /// </summary>
            public string Type
            {
                get
                {
                    return _Type;
                }
                protected set
                {
                    _Type = value;
                }
            }
            string _Type;
            /// <summary>
            /// Вычисление площади
            /// </summary>
            /// <returns></returns>
            public abstract double Area();
            /// <summary>
            /// Приведение к строке, переопределение метода Object
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Type + " has an area equal to " + Area().ToString();
            }
            /// <summary>
            /// Сравнение элементов (для сортировки списка)
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public int CompareTo(object obj)
            {
                Figure p = (Figure)obj;
                if (Area() < p.Area()) return -1;
                else if (Area() == p.Area()) return 0;
                else return 1; //(this.Area() > p.Area())
            }
        }
}
