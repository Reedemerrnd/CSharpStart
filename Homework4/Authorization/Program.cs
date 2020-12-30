using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Авдеев Роман
 * Решить задачу с логинами из урока 2, 
 * только логины и пароли считать из файла в массив. 
 * Создайте структуру Account, содержащую Login и Password.
 * */
namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Account.Authorise();
            Console.ReadLine();
        }
    }
    struct Account
    {
        string login;
        string pass;

        private static Account[] GetAccsFromFile(string path)
        {

            string[] temp = File.ReadAllLines(path);
            Account[] accs = new Account[temp.Length];
            int spcInd;
            for (int i = 0; i < temp.Length; i++)
            {
                spcInd = temp[i].IndexOf(' ');
                accs[i].login = temp[i].Substring(0, spcInd);
                accs[i].pass = temp[i].Substring(spcInd + 1);
            }
            return accs;
        }
        public static void Authorise()
        {
            Account[] accs = Account.GetAccsFromFile("Users.txt");
            int tries = 3;
            Account user;
            do
            {
                Console.WriteLine("Enter login");
                user.login = Console.ReadLine();

                Console.WriteLine("Enter password");
                user.pass = Console.ReadLine();

                if (Account.CheckAccounts(user, accs))
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
        }

        private static bool CheckAccounts(Account usr, Account[] accs)
        {
            for (int i = 0; i < accs.Length; i++)
            {
                if (usr.login == accs[i].login
                    && usr.pass == accs[i].pass) return true;

            }
            return false;
        }
    }
}
