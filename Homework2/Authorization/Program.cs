using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман 
 * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 * (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 * программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 3;
            do
            {
                Console.WriteLine("Enter login");
                string login = Console.ReadLine();

                Console.WriteLine("Enter password");
                string pass = Console.ReadLine();

                if (Authorize(login, pass))
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    tries--;
                }
            }
            while (tries > 0);

            Console.ReadLine();

        }

        static bool Authorize(string login, string pass)
        {
            if (login == "root" && pass == "GeekBrains")
                return true;
            else return false;
        }
    }
}
