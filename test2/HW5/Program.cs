using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * 5.1) Написать программу, которая запрашивает массу и рост человека,
 *  вычисляет его индекс  массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
 * 5.2) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.  
 * */

namespace HW5
{
    class Program
    {
        static void Main()
        {
            //Hello
            Console.WriteLine("Привет! Это программа поможет Вам узнать в норме ли ваши жиры");
            #region 5.1
            //recodrs value
            Console.Write("Введите ваш рост: "); double hight = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес: "); double weight = double.Parse(Console.ReadLine());
            //get IMT(получаем индекс массы тела)
            double IMT = CountIMT(hight,weight);
            Console.WriteLine(WhatNeed(IMT));
            #endregion

            #region 5.2
            //Count for Normalization
            Console.WriteLine(HowMuchNeed());
            #endregion
            //Pause
            Console.ReadLine();

        }
        static double CountIMT (double h, double w)
        {
            return w / (h / 100 * h / 100);
        }
        static string WhatNeed (double IMT)
        {
            if (IMT <= 16) return "У меня пальцы больше чем твоя ляха скелет";
            if (IMT > 16 && IMT <= 18.5) return "Дрыщ";
            if (IMT > 18.5 && IMT <= 24.99) return "Красавчег у тебя все в норме";
            if (IMT >= 25 && IMT < 30) return "Ну все еще нормально но немного похудеть не помешает";
            if (IMT >= 30 && IMT < 35) return "Ты колобок завязывай с пивом на диванчике";
            if (IMT >= 35 && IMT < 40) return "Тебе нужно срочно заняться собой";
            else return "Что ты такое? Давай занимайся собой животное";
        }
        static string HowMuchNeed (double h, double w)
        {

        }
    }
}
