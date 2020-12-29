using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
 * Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
	б) *без использования третьей переменной.
*/

namespace SwapInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int t;
            // вариант а)

            t = a;
            a = b;
            b = t;
            Console.WriteLine(a + " " + b);

            //Вариант б)
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine(a + " " + b);

            Console.ReadLine();



        }
    }
}
