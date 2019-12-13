using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Figure, IPrint /// Наследование от класса "фигура"
    {


        public double height /// высота, объявленная как свойство
        {
            get
            {
                return this._Height;
            }
             set
            {
                this._Height = value;
            }
        }
        double _Height;  /// Высота

        public double width /// ширина, объявленная как свойство
        {
            get
            {
                return this._Width; ;
            }
            set
            {
                this._Width = value;
            }
        }
        double _Width; /// Ширина

       
        public Rectangle(double ph, double pw) /// Конструктор по параметрам "ширина" и "высота"
        {
            this.height = ph;
            this.width = pw;
            this.Type = "Прямоугольник";
        }

        
        public override double Area() /// Вычисление площади
        {
            double Result = this.width * this.height;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString() /// Приведение к строке основных параметров прямоугольника и его площади, переопределение метода Object
        {
            return this.Type + " со сторонами " + this.width + " и "+ this.height + " и площадью " + this.Area().ToString();
        }
    }

}
