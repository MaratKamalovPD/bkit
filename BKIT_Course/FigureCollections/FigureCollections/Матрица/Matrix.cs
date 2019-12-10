using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureCollections
{
    public class Matrix<T>
    {
        
        
        
        Dictionary<string, T> _matrix = new Dictionary<string, T>(); /// Словарь для хранения значений

        
        int maxX; /// Количество элементов по горизонтали (максимальное количество столбцов)

        
        int maxY; /// Количество элементов по вертикали (максимальное количество строк)



        
        IMatrixCheckEmpty<T> сheckEmpty; /// Реализация интерфейса для проверки пустого элемента

        
        public Matrix(int px, int py, IMatrixCheckEmpty<T> сheckEmptyParam)  /// Конструктор
        {
            this.maxX = px;
            this.maxY = py;
            this.сheckEmpty = сheckEmptyParam;
        }

       
        public T this[int x, int y] /// Индексатор для доступа к данных
        {
            set
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                this._matrix.Add(key, value);
            }
            get
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
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

        
        void CheckBounds(int x, int y) /// Проверка границ
        {
            if (x < 0 || x >= this.maxX)
            {
                throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
            }
            if (y < 0 || y >= this.maxY)
            {
                throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
            }
        }

        
        string DictKey(int x, int y) /// Формирование ключа
        {
            return x.ToString() + "_" + y.ToString();
        }

        
        public override string ToString() /// Приведение к строке
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием 
            //большого количества обычных строк

            StringBuilder b = new StringBuilder();

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
                    if (!this.сheckEmpty.checkEmptyElement(this[i, j]))
                    {
                        //Добавить приведенный к строке текущий элемент
                        b.Append(this[i, j].ToString());
                    }
                    else
                    {
                        //Иначе добавить признак пустого значения
                        b.Append(" - ");
                    }
                }
                b.Append("]\n");
            }
            return b.ToString();
        }
    }
}
