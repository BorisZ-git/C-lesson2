using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 *  Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000.
 *  Хорошим называется число, которое делится на сумму своих цифр.
 *  Реализовать подсчет  времени выполнения программы, используя структуру DateTime.
 *  */ 


namespace HW6
{
    class Program
    {
        static void Main()
        {
            //record time (записать текущие время)
            DateTime start = DateTime.Now;
            //get good numbers(получить хорошие числа)
            int count = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (i%Sum(i) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);            
            Console.WriteLine(DateTime.Now - start);            
            Console.ReadLine();
        }
        //int count1 = 39%10; // получаем последнюю цифру
        //int count2 = (39 / 10) % 10; // получаем предпоследнюю в данном примере первую цифру
        //реализуем цикл пока не получим все цифры
        static int Sum(int i)
        {
            int b = 0;
            do
            {
                b = b + (i % 10);
                i = i / 10;
            } while (i >= 1);
            return b;

        }
    }
}
