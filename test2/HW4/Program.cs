using System;
using System.Linq;
/* Boris Z
 * Реализовать метод проверки логина и пароля.
 *  На вход подается логин и пароль.
 *   На выходе  истина, если прошел авторизацию, и ложь, если не прошел.
 *    Используя метод проверки логина и  пароля, написать программу:
 *     пользователь вводит логин и пароль, программа пропускает его  дальше или не пропускает.
 *      С помощью цикла do while ограничить ввод пароля тремя попытками; 
 *      */ 
 namespace HW4
{
    class Program
    {
        //set login and pass(устанавливаем логин и пароль)
        static string login = "login";
        static string pass = "pass";
        static void Main()
        {
            //Hello (Привет)
            Console.WriteLine("Добрый день!");
            //Check  (инициализируем проверку на логин и пароль)
            int i = 0;
            do
            {
                Console.Write("Введите ваш логин: "); string UserLogin = Console.ReadLine();
                Console.Write("Введите ваш пароль: "); string UserPass = Console.ReadLine();                
                if (TrueFalse(UserLogin, UserPass)) break;
                else i++;
                //return work only in Main, alternative Environment.Exit(0);
                //ретерн закрывает только функцию, альтернатива ему закрывает программу.
                if (i == 3) return;
            } while (true) ;
            //Go (Идем дальше)
            Console.WriteLine("Вы успешно прошли авторизацию!");
            //Pause (Пауза)
            Console.ReadLine();
        }
        static bool TrueFalse(string UserLogin, string UserPass)
        {            
            //check (Проверяем введенные данные с установленными)
            if (UserLogin == login && UserPass == pass) return true;
            else return false;            
        }
    }
}
