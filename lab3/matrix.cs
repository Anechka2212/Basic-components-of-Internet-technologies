using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    public class Matrix<T>
    {
        /// <summary>
        /// Словарь для хранения значений
        /// </summary>
        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        /// <summary>
        /// Количество элементов по горизонтали (максимальное количество столбцов)
        /// </summary>
        int maxX;
        /// <summary>
        /// Количество элементов по вертикали (максимальное количество строк)
        /// </summary>
        int maxY;
        /// <summary>
        /// Количество элементов в глубину
        /// </summary>
        int maxZ;
        /// <summary>
        /// Пустой элемент, который возвращается если элемент с нужными координатами не был задан
        /// </summary>
        T nullElement;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Matrix(int px, int py, int pz, T nullElementParam)
        {
            maxX = px;
            maxY = py;
            maxZ = pz;
            nullElement = nullElementParam;
        }
        /// <summary>
        /// Индексатор для доступа к данных
        /// </summary>
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (_matrix.ContainsKey(key))
                {
                    return _matrix[key];
                }
                else
                {
                    return nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                _matrix.Add(key, value);
            }
        }
        /// <summary>
        /// Проверка границ
        /// </summary>
        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= maxX) throw new Exception("x = " + x + " comes out");
            if (y < 0 || y >= maxY) throw new Exception("y = " + y + " comes out");
            if (z < 0 || z >= maxZ) throw new Exception("z = " + z + " comes out");
        }
        /// <summary>
        /// Формирование ключа
        /// </summary>
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }
        /// <summary>
        /// Приведение к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием
            //большого количества обычных строк
            StringBuilder b = new StringBuilder();
            for (int k = 0; k < maxZ; k++)
            {
                b.Append("[");
                for (int j = 0; j < maxY; j++)
                {
                    if (j > 0) b.Append("\t");
                    b.Append("[");
                    for (int i = 0; i < maxX; i++)
                    {
                        b.Append(this[i, j, k].ToString());
                        if (i != (maxX - 1)) b.Append(", ");
                    }
                    b.Append("]");
                }
                b.Append("]\n");
            }
            return b.ToString();
        }
    }
}
