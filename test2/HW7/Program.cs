using System;
using System.Linq;

/* Boris Z
 * 6.1 Разработать рекурсивный метод, который выводит на экран числа от a до b;
 * 6.2 Разработать рекурсивный метод, который считает сумму чисел от a до b. 
 * */

namespace HW7
{
    class Program
    {
        static int sum = 0;
        static void Main()
        {
            //Hello
            Console.WriteLine("Привет! Эта программа выводит на экран числа от a до b");
            Console.Write("От какого числа выводить: "); int a = int.Parse(Console.ReadLine());
            Console.Write("До какого числа выводить: "); int b = int.Parse(Console.ReadLine());
            //6.1
            FromTo(a, b);
            //6.2
            CountSum(a, b);
            Console.WriteLine(sum);
            //Pause
            Console.ReadLine();
        }
        static void FromTo(int a, int b)
        {
            Console.WriteLine($"{a}");
            if (a < b) FromTo(a + 1, b);
        }
        static void CountSum(int a, int b)
        {
            sum = sum + a; 
            if (a < b) CountSum(a + 1, b);
        }
    }
}
