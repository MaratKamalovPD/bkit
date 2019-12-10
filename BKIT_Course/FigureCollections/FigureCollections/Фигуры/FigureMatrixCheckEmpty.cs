using System;

namespace FigureCollections
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Figure>
    {
        
        public Figure getEmptyElement() /// В качестве пустого элемента возвращается null
        {
            return null;
        }

        
        public bool checkEmptyElement(Figure element) /// Проверка что переданный параметр равен null
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}
