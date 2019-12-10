using System;

namespace FigureCollections
{
    
    public interface IMatrixCheckEmpty<T> /// Проверка пустого элемента матрицы
    {

        T getEmptyElement(); /// Возвращает пустой элемент

       
        bool checkEmptyElement(T element);  /// Проверка что элемент является пустым
    }
}
