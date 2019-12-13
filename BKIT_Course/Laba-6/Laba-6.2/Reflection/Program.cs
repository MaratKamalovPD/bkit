using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        
        /// Проверка, что у свойства есть атрибут заданного типа
        
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;

            //Поиск атрибутов с заданным типом
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }

            return Result;
        }

        
        

        
        /// Получение информации о типе
        
        static void TypeInfo()
        {
            ForInspection obj = new ForInspection();
            Type t = obj.GetType();

            
            

            Console.WriteLine("\n Информация о конструкторах:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n Информация о методах:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n Информация о свойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }


            
        }

       
        static void InvokeMemberInfo()  /// Пример использования метода 
        {
            Type t = typeof(ForInspection);
            Console.WriteLine("\nВызов метода:");

            //Создание объекта
            ForInspection fi = (ForInspection)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

            //Параметры вызова метода
            object[] parameters = new object[] { 3, 2 };
            //Вызов метода
            object Result = t.InvokeMember("Plus", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("Plus(3,2)={0}", Result);
        }

        static void Main(string[] args)
        {
            
            TypeInfo();
            InvokeMemberInfo();
            

            Console.ReadLine();
        }
    }
}
