using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Авдеев Роман
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/
namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Show(1, 10);
            Console.WriteLine(Sum(1,10));

            Console.ReadKey();
        }
        static void Show (int a, int b)
        {
            Console.WriteLine(a);
            if (a != b)
                Show(a + 1, b);
        }
        static int Sum (int a, int b)
        {
            if (a == b)
                return a;
            else return b + Sum(a, b - 1);
        }
    }
}
