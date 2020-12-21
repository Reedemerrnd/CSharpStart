using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Авдеев Роман
//Написать метод, возвращающий минимальное из трёх чисел.
namespace MinOfThree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MinOfThree(1,2,3));
            Console.WriteLine(MinOfThree(10, 2, 30));
            Console.WriteLine(MinOfThree(100, 20, 3));

            Console.ReadKey();
        }
        static double MinOfThree(double a, double b, double c)
        {
            if (a < b && a < c)
                return a;
            else if (b < a && b < c)
                return b;
            else return c;
        }
    }
}
