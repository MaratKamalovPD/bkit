using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
       
    abstract class Figure  /// Класс фигура
    {
        
        
        public string Type /// Тип фигуры
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
 
        
        
        public abstract double Area(); /// Вычисление площади

        
        
        
        public override string ToString() /// Приведение к строке, переопределение метода Object
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
    }
}
