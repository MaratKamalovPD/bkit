using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
       
    abstract class Figure  /// абстрактный класс "фигура"
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
    }
}
