using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Avdeev Roman
 * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например:
badc являются перестановкой abcd.
*/
namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "a bc dfe ,";
            string str2 = "fe b  c,ad";
            Console.WriteLine(IsAnagram(str1,str2));
            Console.ReadKey();
        }

        private static bool IsAnagram(string str1, string str2)
        {
            char[] temp1 = str1.ToCharArray();
            char[] temp2 = str2.ToCharArray();
            Array.Sort(temp1);
            Array.Sort(temp2);
            str1 = temp1.ToString();
            str2 = temp2.ToString();
            if (str1 == str2) return true;
            else return false;
        }
    }
}
