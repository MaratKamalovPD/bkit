using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureCollections
{
    public class Matrix<T>
    {
        
        
        
        Dictionary<string, T> _matrix = new Dictionary<string, T>(); /// Словарь для хранения значений

        
        int maxX; /// Количество элементов по ширине 
   
        int maxY; /// Количество элементов по длине
        int maxZ; /// Количество элементов по высоте 




        IMatrixCheckEmpty<T> сheckEmpty; /// Реализация интерфейса для проверки пустого элемента

        
        public Matrix(int px, int py, int pz, IMatrixCheckEmpty<T> сheckEmptyParam)  /// Конструктор
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.сheckEmpty = сheckEmptyParam;
        }

       
        public T this[int x, int y, int z] /// Индексатор для доступа к данных
        {
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.сheckEmpty.getEmptyElement();
                }
            }
        }

        
        void CheckBounds(int x, int y, int z) /// Проверка границ
        {
            if (x < 0 || x >= this.maxX)
            {
                throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
            }
            if (y < 0 || y >= this.maxY)
            {
                throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
            }
            if (z < 0 || z >= this.maxZ)
            {
                throw new ArgumentOutOfRangeException("z", "z=" + z + " выходит за границы");
            }
        }

        
        string DictKey(int x, int y, int z) /// Формирование ключа
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

        
        public override string ToString() /// Приведение к строке матрицы
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием 
            //большого количества обычных строк

            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxZ; k++)
            {
                b.Append("z=");
                b.Append(k+1);
                b.Append("\n");
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        //Добавление разделителя-табуляции
                        if (i > 0)
                        {
                            b.Append("\t");
                        }
                        //Если текущий элемент не пустой
                        if (!this.сheckEmpty.checkEmptyElement(this[i, j, k]))
                        {
                            //Добавить приведенный к строке текущий элемент
                            b.Append(this[i, j, k].ToString());
                        }
                        else
                        {
                            //Иначе добавить признак пустого значения
                            b.Append(" 0 ");
                        }
                    }
                    b.Append("]\n");
                }
               
            }
            return b.ToString();
        }
    }
}
