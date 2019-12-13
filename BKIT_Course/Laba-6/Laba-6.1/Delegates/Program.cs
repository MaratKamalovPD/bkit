using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    //Название делегата при объявлении указывается "вместо" названия метода
    delegate double PlusOrMinus(int p1, double p2); /// Делигат, принимающий несколько параметров произвольного типа

    class Program
    {
        //Методы, соответствующие делегату
        static double Plus(int p1, double p2)
        { return p1 + p2; }
       

        /// Использование делегата
        
        static void PlusOrMinusMethod(string str, int i1, double i2, PlusOrMinus PlusOrMinusParam) /// Метод, принимающий разработанный мною делегат
        {
            double Result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }

      
        static void PlusOrMinusMethodFunc(string str, int i1, double i2, Func<int, double, double> PlusOrMinusParam)  ///  Обощенного делегат Func<>
        {
           double Result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());

            // Func<int, string, bool> - делегат принимает параметры типа int и string и возвращает bool          

            // Если метод должен возвращать void, то используется делегат Action
            // Action<int, string> - делегат принимает параметры типа int и string и возвращает void
            // Action как правило используется для разработки групповых делегатов, которые используются в событиях 

        }

        

        static void Main(string[] args)
        {
            int i1 = 3;
            double i2 = 2.5;

            PlusOrMinusMethod("Плюс: ", i1, i2, Plus);
            

            //Создание экземпляра делегата на основе метода
            PlusOrMinus pm1 = new PlusOrMinus(Plus);
            PlusOrMinusMethod("Создание экземпляра делегата на основе метода: ", i1, i2, pm1); /// Вызов метода

            

            //Лямбда-выражение в виде переменной
            PlusOrMinus pm2 = (int x, double y) =>
            {
                double z = x + y;
                return z;
            };
            double test = pm2(1, 2);
            PlusOrMinusMethod("Создание экземпляра делегата на основе лямбда-выражения в виде переменной: ", i1, i2, pm2);/// Вызов метода

           
            ////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\nИспользование обощенного делегата Func<>");

            PlusOrMinusMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Plus);

            PlusOrMinusMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x + y);


            Console.ReadLine();
        }
    }
}
