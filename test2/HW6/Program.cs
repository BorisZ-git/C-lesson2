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
            DateTime start = DateTime.Now;
            //int count1 = 39%10; // получаем последнюю цифру
            //int count2 = (39 / 10) % 10; // получаем предпоследнюю в данном примере первую цифру
            //int count3 = (3934 / 10) % 10; //


            #region it's sum of value
            int a = 39347;
            int b = 0;
            do
            {                
                b = b + (a % 10);
                a = a/10 ;
            } while (a >= 1);
            #endregion


            //for (int i = 0; i < 1000;i++)
            //{                
            //    if (i%10 == 0)
            //    {
            //        count++;
            //    }
            //}
            Console.WriteLine(b);
            Console.WriteLine(DateTime.Now - start);            
            Console.ReadLine();

        }
    }
}
