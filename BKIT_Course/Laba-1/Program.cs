using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IU5_35B
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Title = "Камалов ИУ5-35"; // изменяет заголовок консоли 
            if ((args.Length) == 3) // Проверка наличиная 3-ех аргументов командной строки
            {
                new Biquadratic_Equation(true, args[0], args[1], args[2]);
            }
            else
            {
                new Biquadratic_Equation(false, "0", "0", "0");
            }
            return;
        }
    }
    class Biquadratic_Equation
    {
        private double a;
        private double b;
        private double c;
        private double x1;
        private double x2;
        private double x3;
        private double x4;
        public Biquadratic_Equation(bool fl, string a, string b, string c)
        {
            Solution(fl, a, b, c);
        }
        public void Solution(bool flag, string a1, string b1, string c1)
        {
            if (!flag)
            {
                Console.Write("Имеется уравнение вида: \n");
                Console.Write("A*x^4 + B*x^2 + C = 0 \n");
                Console.Write("Вам необходимо ввести коэффициенты\n");
                while (true) // ввод коэффициента а
                {
                    Console.Write("Введите коэффициент A ");
                    string str = Console.ReadLine();
                    bool ConvertResult = double.TryParse(str, out a);
                    if (ConvertResult)
                    {
                        Console.WriteLine("Вы ввели число " + a.ToString("F5"));
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Что-то пошло не так, попробуйте еще раз \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (true) // ввод коэффициента b
                {
                    Console.Write("Введите коэффициент B ");
                    string str = Console.ReadLine();
                    bool ConvertResult = double.TryParse(str, out b);
                    if (ConvertResult)
                    {
                        Console.WriteLine("Вы ввели число " + b.ToString("F5"));
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Что-то пошло не так, попробуйте еще раз \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (true) // ввод коэффициента с
                {
                    Console.Write("Введите коэффициент C ");
                    string str = Console.ReadLine();
                    bool ConvertResult = double.TryParse(str, out c);
                    if (ConvertResult)
                    {
                        Console.WriteLine("Вы ввели число " + c.ToString("F5"));
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Что-то пошло не так, попробуйте еще раз \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            else
            {
                bool ConvertResult1 = double.TryParse(a1, out a);
                if (ConvertResult1)
                {
                    Console.WriteLine("Первый аргумент командной строки " + a.ToString("F5"));

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("К сожалению, первый аргумент командной строки не соответствует нормам вводимых данных, попробуйте повторить попытку вручную \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (true) // повторный ввод коэффициента а
                    {
                        Console.Write("Введите коэффициент A ");
                        string str = Console.ReadLine();
                        bool ConvertResult2 = double.TryParse(str, out a);
                        if (ConvertResult2)
                        {
                            Console.WriteLine("Вы ввели число " + a.ToString("F5"));
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Что-то пошло не так, попробуйте еще раз \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                bool ConvertResult3 = double.TryParse(b1, out b);
                if (ConvertResult3)
                {
                    Console.WriteLine("Второй аргумент командной строки " + b.ToString("F5"));

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("К сожалению, втророй аргумент командной строки не соответствует нормам вводимых данных, попробуйте повторить попытку вручную \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (true) // повторный ввод коэффициента b
                    {
                        Console.Write("Введите коэффициент B ");
                        string str = Console.ReadLine();
                        bool ConvertResult4 = double.TryParse(str, out b);
                        if (ConvertResult4)
                        {
                            Console.WriteLine("Вы ввели число " + b.ToString("F5"));
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Что-то пошло не так, попробуйте еще раз \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                bool ConvertResult5 = double.TryParse(c1, out c);
                if (ConvertResult5)
                {
                    Console.WriteLine("Третий аргумент командной строки " + c.ToString("F5"));

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("К сожалению, третий аргумент командной строки не соответствует нормам вводимых данных, попробуйте повторить попытку вручную \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    while (true) // повторный ввод коэффициента c
                    {
                        Console.Write("Введите коэффициент C ");
                        string str = Console.ReadLine();
                        bool ConvertResult6 = double.TryParse(str, out c);
                        if (ConvertResult6)
                        {
                            Console.WriteLine("Вы ввели число " + c.ToString("F5"));
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Что-то пошло не так, попробуйте еще раз \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
            if ((a == 0) && (b == 0) && (c == 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Уравнение обращается в равенство при любых действительных Х \n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if ((a == 0) && (b == 0) && (c != 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Уравнение не имеет решений \n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if ((a != 0) && (b != 0))
            {
                bool fl1 = false;
                bool fl2 = false;
                double discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (discriminant >= 0)
                {
                    x1 = (-b + Math.Pow(discriminant, 0.5)) / (2 * a);
                    x2 = (-b - Math.Pow(discriminant, 0.5)) / (2 * a);
                    if (x1 >= 0)
                    {
                        x3 = Math.Pow(x1, 0.5);
                        x4 = -Math.Pow(x1, 0.5);
                        fl1 = true;
                    }
                    if (x2 >= 0)
                    {
                        x1 = Math.Pow(x2, 0.5);
                        x2 = -Math.Pow(x2, 0.5);
                        fl2 = true;
                    }
                    if ((fl1) && (fl2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения x1={0},x2={1},x3={2},x4={3}", x1, x2, x3, x4);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if ((!fl1) && (fl2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения x1={0},x2={1}", x1, x2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if ((fl1) && (!fl2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения x1={0},x2={1}", x3, x4);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if ((!fl1) && (!fl2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет решений \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Уравнение не имеет решений \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }




            }
            if ((a == 0) && (b != 0))
            {
                if (c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения x1=0");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if ((c / b) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет решений \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        x1 = Math.Pow(-c / b, 0.5);
                        x2 = -Math.Pow(-c / b, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения x1={0},x2={1}", x1, x2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }



            }
            if ((a != 0) && (b == 0))
            {
                if (c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения x1=0");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if ((c / a) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет решений \n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        x1 = Math.Pow(-c / a, 0.25);
                        x2 = -Math.Pow(-c / a, 0.25);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения x1={0},x2={1}", x1, x2);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }   
        }
    }
}
