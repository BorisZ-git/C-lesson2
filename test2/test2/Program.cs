using System;
/* Boris Z
 * 1. Написать метод возвращающий минимальное из трех чисел
 * */

namespace test2
{
    class Program
    {
        static void Main()
        {
            //Hello(Привет)
            Console.WriteLine("Привет! Эта программа возвращает минимальное из трех чисел!");
            //Records variables(запись переменных)
            int a = UserValue("Введите первое число: ");
            int b = UserValue("Введите второе число: ");
            int c = UserValue("Введите трерье число: ");
        }
        static int UserValue(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
    }
}
