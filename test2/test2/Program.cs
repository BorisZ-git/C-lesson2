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
            //Show the min(показать минимальное)
            Console.WriteLine(ShowMin(a,b,c));
            //Pause
            Console.ReadLine();
        }
        static int UserValue(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        static int ShowMin(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            else if (b < a && b < c) return b;
            else if (c < a && c < b) return c;
            else return 100;
        }
    }
}
