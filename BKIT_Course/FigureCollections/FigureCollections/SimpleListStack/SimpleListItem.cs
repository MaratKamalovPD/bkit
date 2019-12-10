using System;

namespace FigureCollections
{
    
    public class SimpleListItem<T> /// Элемент списка
    {
        
        public T data { get; set; } /// Данные

        
        public SimpleListItem<T> next { get; set; } /// Следующий элемент

        
        public SimpleListItem(T param) ///конструктор
        {
            this.data = param;
        }
    }
}
