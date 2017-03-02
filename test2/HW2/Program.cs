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
            string a = UserValue("Введите число: ");
            //Show the length(показать колво знаков)
            Console.WriteLine($"Количество цифл числа: {ShowLength(a)}");
            //Pause(пауза)
            Console.ReadLine();
        }
        //Realize method return value of string(Возвращает строковое значение)
        static string UserValue(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        //Realize method return Lenght of string that the give to method (Возвращает число знаков)
        static int ShowLength(string a)
        {
            return a.Length;
        }

    }
}
