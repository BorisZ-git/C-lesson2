using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * а) Написать программу, которая запрашивает массу и рост человека,
 *  вычисляет его индекс  массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.  
 * */

namespace HW5
{
    class Program
    {
        static void Main()
        {
            //Hello
            Console.WriteLine("Привет! Это программа поможет Вам узнать в норме ли ваши жиры");
            //recodrs value
            Console.Write("Введите ваш рост: "); double h = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес: "); double w = double.Parse(Console.ReadLine());
            double IMT = CountIMT(h, w);
            Console.WriteLine(IMT);
            Console.ReadLine();
        }
        static double CountIMT (double hight, double weight)
        {
            return weight/(hight/100*hight/100);
        }
    }
}
