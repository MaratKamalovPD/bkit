using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Figure, IPrint /// Наследование от класса "фигура"
    {

        public double radius /// радиус, объявленный как свойство
        {
            get
            {
                return this._Radius;
            }
            set
            {
                this._Radius = value;
            }
        }
        double _Radius;  /// радиус

        

       
        public Circle(double pr) /// Конструктор по параметру радиус
        {
            this.radius = pr;
            this.Type = "Круг";
        }

        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString() /// Приведение к строке основных параметров круга и его площади, переопределение метода Object
        {
            return this.Type + " с радиусом " + this.radius +  " и площадью " + this.Area().ToString();
        }
    }
}
