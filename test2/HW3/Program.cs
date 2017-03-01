using System;
/* Boris Z
 *  С клавиатуры вводятся числа, пока не будет введен 0.
 *   Подсчитать сумму всех нечетных положительных чисел. 
 *   */
  
namespace HW3
{
    class Program
    {
        static void Main()
        {
            //Hello(Привет)
            Console.WriteLine("Добрый день! Эта программа подсчитает сумму всех\n" + 
                "нечетных положительных чисел, пока Вы не введете 0");
            //Realize(Реализация программы)
            Console.WriteLine(DoWhileZero());
            //Pause(Пауза)
            Console.ReadLine();
        }
        //Write method that return sum(Пишем метод который возвращает сумму)
    static int DoWhileZero()
        {
            int UserNumber;
            int sum = 0;
            //Use division for catch odd numbers
            //(Используем деление по модулю для ловли нечетных чисел)
            do
            {
                Console.Write("Введите число: ");
                UserNumber = int.Parse(Console.ReadLine());
                if (UserNumber > 0 && UserNumber%2 !=0)
                {
                    sum += UserNumber;
                }
            } while (UserNumber != 0);            
            return sum;
    }

}
}
