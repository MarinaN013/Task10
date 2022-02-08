using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    class Program
    {
        static void ttt((int a, int b) p)
        {
            try
            {
                if (p.a % p.b != 0)
                    throw new Exception("Получена ошибка: Число 1 не делится нацело на число 2. Деление произведено с погрешностью. ");
                else
                    Console.WriteLine("Результат деления: " + p.a / p.b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Результат деления: -1");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Результат деления: " + p.a / p.b);
            }
        }
        static (int, int) SaveConvert(string[] s)
        {
            int a, b;

            try
            {
                a = Convert.ToInt32(s[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Получена ошибка: " + e.Message + "\nДля числа 1 будет сгенерировано случайное значение.");
                Random r = new Random();
                a = r.Next(1, 100);
            }
            try
            {
                b = Convert.ToInt32(s[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Получена ошибка: " + e.Message + "\nДля числа 2 будет сгенерировано случайное значение.");
                Random r = new Random();
                b = r.Next(1, 100);
            }

            return (a, b);
        }
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            try
            {
                if (s.Length > 2)
                    throw new Exception("Введено больше двух чисел. Работа программы завершена.");
                else
                    ttt(SaveConvert(s));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}