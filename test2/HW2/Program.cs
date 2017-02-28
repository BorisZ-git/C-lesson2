using System;
/* Boris Z
 *  2.Написать метод подсчета количества цифр числа;
 * */

namespace HW2
{
    class Program
    {
        static void Main()
        {
            //Hello(Привет)
            Console.WriteLine("Привет! Эта программа реализует метод подсчета количества цифр числа!");
            //Records variables(запись переменных)
            int a = UserValue("Введите первое число: ");
            //Show the min(показать минимальное)
            Console.WriteLine($"Количество цифл числа: {ShowLenght(a)}");
            //Pause
            Console.ReadLine();

        }
        static int UserValue(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        static int ShowLenght(int a)
        {
            int Lenght = 100;
            return Lenght;
        }

    }
}
