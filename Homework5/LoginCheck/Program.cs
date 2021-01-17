using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/* Avdeev Roman
 * Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
*/
namespace LoginCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] { "login", "Login", "1login", "loginloginlogin", "ёlogin", "l",".login"," login" };
            //without regex
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length>=2 && str[i].Length<=10 
                    && (str[i][0] >='a' && str[i][0]<='z' || str[i][0] >= 'A' && str[i][0] <= 'Z'))
                {
                    Console.WriteLine($"{str[i]} - true");
                }
                else Console.WriteLine($"{str[i]} - false");
            }

            // with regex
            Console.WriteLine("With Regexp");
            Regex rgx = new Regex(@"^[a-z]\w{1,9}$", RegexOptions.IgnoreCase);
            foreach (string s in str) Console.WriteLine($"{s} - {rgx.IsMatch(s)}");
            Console.ReadLine();
        }
    }
}
