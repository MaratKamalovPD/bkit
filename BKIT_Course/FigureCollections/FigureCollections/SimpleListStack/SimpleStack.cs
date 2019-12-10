using System;

namespace FigureCollections
{
    
    class SimpleStack<T> : SimpleList<T> where T : IComparable /// Класс стек, который наследуется от SimpleList
    {

        public void Push(T element)  /// Добавление в стек
        {
             
            Add(element); //Добавление в конец списка уже реализовано
        }

        
        public T Pop() /// Удаление и чтение из стека
        {
            
            T Result = default(T); //default(T) - значение для типа T по умолчанию
            
            if (this.Count == 0) return Result; //Если стек пуст, возвращается значение по умолчанию для типа
            
            if (this.Count == 1) //Если элемент единственный
            {
                
                Result = this.first.data; //то из него читаются данные
                
                this.first = null; //обнуляются указатели начала и конца списка
                this.last = null;
            }

            else //В списке более одного элемента
            {
                
                SimpleListItem<T> newLast = this.GetItem(this.Count - 2); //Поиск предпоследнего элемента
                
                Result = newLast.next.data; //Чтение значения из последнего элемента
                
                this.last = newLast; //предпоследний элемент считается последним
                
                newLast.next = null; //последний элемент удаляется из списка
            }
            
            this.Count--; //Уменьшение количества элементов в списке
                       
            return Result; //Возврат результата 
        }
    }
}
