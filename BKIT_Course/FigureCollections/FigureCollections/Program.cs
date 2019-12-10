using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //+++++++++++++++++++++++++++++++++++++++++++++++++
            
            Rectangle rect = new Rectangle(5, 4); //Создание объектов классов фигур:
            Square square = new Square(5);
            Circle circle = new Circle(5);

            ///________________________________________________________________________________________________
            Console.WriteLine("\nArrayList");
            ArrayList al = new ArrayList(); /// Создание коллекции  ArrayList и сохранение прямоугольника, квадрата и круга в коллекцию
            al.Add(circle);
            al.Add(rect);
            al.Add(square);

            foreach (var x in al) Console.WriteLine(x); /// Вывод содержимого  коллекции



            ///________________________________________________________________________________________________
            Console.WriteLine("\nList<Figure>");
            List<Figure> fl = new List<Figure>(); /// Создание коллекции класса List<Figure> и сохранение объектов в коллекцию
            fl.Add(circle);
            fl.Add(rect);
            fl.Add(square);

            
            fl.Sort(); /// Сортировка коллекции

            Console.WriteLine("\nПосле сортировки:");
            foreach (var x in fl) Console.WriteLine(x); /// Вывод содержимого  коллекции

            ///________________________________________________________________________________________________
            Console.WriteLine("\nМатрица"); /// Пример использования разреженной матрицы для геометрических фигур
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, new FigureMatrixCheckEmpty()); 
            matrix[0, 0] = rect;
            matrix[1, 1] = square;
            matrix[2, 2] = circle;
            Console.WriteLine(matrix.ToString());


            try  //Выход за границы индекса и обработка исключения
            {
                Figure temp = matrix[123, 123];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            ///________________________________________________________________________________________________
            Console.WriteLine("\nСтек"); /// Пример работы класса  SimpleStack на основе геометрических фигур

            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            
            stack.Push(rect); //добавление данных в стек
            stack.Push(square);
            stack.Push(circle);
            
            while (stack.Count > 0) //чтение данных из стека
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
