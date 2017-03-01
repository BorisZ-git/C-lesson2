using System;
/* Boris Z
 *  С клавиатуры вводятся числа, пока не будет введен 0.
 *   Подсчитать сумму всех нечетных положительных чисел; 
 *   */
  
namespace HW3
{
    class Program
    {
        static void Main()
        {
            //Hello
            Console.WriteLine("Добрый день! Эта программа подсчитает сумму всех\n" + 
                "нечетных положительных чисел, пока Вы не введете 0");
            //operation
            Console.WriteLine(DoWhileZero());
            //Pause
            Console.ReadLine();
        }
    static int DoWhileZero()
        {
            int UserNumber;
            int sum = 0;
            do
            {
                UserNumber = int.Parse(Console.ReadLine());
                if (UserNumber > 0 && UserNumber%2 !=0)
                {
                    sum += UserNumber;
                }
            } while (UserNumber == 0);            
            return sum;
    }

}
}
