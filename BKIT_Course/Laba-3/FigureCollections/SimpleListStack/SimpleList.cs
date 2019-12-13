using System;
using System.Collections.Generic;

namespace FigureCollections
{
    
    public class SimpleList<T> : IEnumerable<T> /// Список
        where T : IComparable
    {
        
        protected SimpleListItem<T> first = null; /// Первый элемент списка

        
        protected SimpleListItem<T> last = null; /// Последний элемент списка

        
        public int Count /// Количество элементов
        {
            get { return _count; }
            protected set { _count = value; }
        }
        int _count;

        
        public void Add(T element)  /// Добавление элемента
        {
            SimpleListItem<T> newItem = new SimpleListItem<T>(element);
            this.Count++;

            
            if (last == null) //Добавление первого элемента
            {
                this.first = newItem;
                this.last = newItem;
            }

            else //Добавление следующих элементов
            {
                
                this.last.next = newItem; //Присоединение элемента к цепочке
               
                this.last = newItem;  //Просоединенный элемент считается последним
            }
        }

        
        public SimpleListItem<T> GetItem(int number) /// Чтение контейнера с заданным номером
        {
            if ((number < 0) || (number >= this.Count))
            {
                
                throw new Exception("Выход за границу индекса"); //Можно создать собственный класс исключения
            }

            SimpleListItem<T> current = this.first;
            int i = 0;

            
            while (i < number) //Пропускаем нужное количество элементов
            {
                
                current = current.next; //Переход к следующему элементу
                
                i++; //Увеличение счетчика
            }

            return current;
        }

        
        public T Get(int number) /// Чтение элемента с заданным номером
        {
            return GetItem(number).data;
        }

        
        public IEnumerator<T> GetEnumerator() /// Для перебора коллекции
        {
            SimpleListItem<T> current = this.first;

            
            while (current != null) //Перебор элементов
            {
                
                yield return current.data; //Возврат текущего значения
                
                current = current.next; //Переход к следующему элементу
            }
        }

        //Реализация обобщенного IEnumerator<T> требует реализации необобщенного интерфейса
        //Данный метод добавляется автоматически при реализации интерфейса
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
        public void Sort() /// Cортировка
        {
            Sort(0, this.Count - 1);
        }

        
        private void Sort(int low, int high)  /// Алгоритм быстрой сортировки
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            } while (i <= j);

            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }

        
        private void Swap(int i, int j) /// Вспомогательный метод для обмена элементов при сортировке
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }
}
