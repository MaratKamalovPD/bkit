using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square : Rectangle, IPrint /// Наследование от класса "прямоугольник"
    {
        public Square(double size) /// Конструктор по длине стороны
            : base(size, size) /// переопределение конструктора базового класса "прямоугольник". Конструктор будет вызываться при создании экземпляра производного класса "Квадрат"
        {
            this.Type = "Квадрат";
        }
        public override string ToString() /// Приведение к строке основных параметров прямоугольника и его площади, переопределение метода Object
        {
            return this.Type + " со стороной " + this.height +  " и площадью " + this.Area().ToString();
        }
    }
}
