using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Figure, IPrint
    {
        
        
        
        double height;  /// Высота

        
        double width; /// Ширина

       
        public Rectangle(double ph, double pw) /// Основной конструктор
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
    }
}
