using System;
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
        static void Main()
        {


            //Hello
            Console.WriteLine("Добрый день!");
            //records valuable
            Console.Write("Введите ваш логин: "); string UserLogin = Console.ReadLine();
            Console.Write("Введите ваш пароль: "); string UserPass = Console.ReadLine();
            //check
            Console.WriteLine(TrueFalse(UserLogin, UserPass));
            Console.ReadLine();
            //GoStop
            if (TrueFalse(UserLogin, UserPass)) Console.WriteLine("Проходи");
            else if (TrueFalse(UserLogin, UserPass) == false) Console.WriteLine("Стоп");
        }
        static bool TrueFalse(string UserLogin, string UserPass)
        {
            //set login and pass
            string login = "login";
            string pass = "pass";
            //check
            if (UserLogin == login && UserPass == pass) return true;
            else return false;
            
        }
    }
}
