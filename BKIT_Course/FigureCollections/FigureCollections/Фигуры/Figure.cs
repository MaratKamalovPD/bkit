using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FigureCollections
{

    abstract class Figure : IComparable  /// абстрактный класс "фигура" с добавлением реализации интерфейса IComparable
    {


        public string Type /// Тип фигуры, объявленный как свойство
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;



        public abstract double Area(); /// Виртуальный метод для вычисления площади




        public override string ToString() /// Приведение к строке основных параметров фигуры и ее площади, переопределение метода Object
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        
        
        
        
        /// </returns>
        public int CompareTo(object obj) // сортировка по площади фигуры
        {
            //Приведение параметра к типу "фигура"
            Figure p = (Figure)obj;
            //Сравнение
            if (this.Area() < p.Area()) return -1; /// -1 - если левый параметр меньше правого
            else if (this.Area() == p.Area()) return 0; /// 0 - параметры равны
            else return 1; //(this.Area() > p.Area())  1 - правый параметр меньше левого
        }
    }
}
