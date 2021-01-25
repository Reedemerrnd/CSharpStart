using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    /*Avdeev Roman
     * Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
     * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    */
    public delegate double Fun(double x, double a);

    class Program
    {

        public static void Table(Fun f, double a, double b, double c = 1)
        {
            for (double x=a;x<=b;x++)
            {
                Console.WriteLine($"{c}*f({x}) = {f(x,c)}");                
            }
        }
 
        public static double MyPow(double x, double c)
        {
            return c * x * x;
        }
        public static double MySin(double x, double c)
        {
            return c * Math.Sin(x);
        }

        static void Main()
        {
            Table(MyPow, -2, 2,6);
            Console.WriteLine();
            Table(MyPow, -2, 2);
            Console.WriteLine();
            Table(MySin, -2, 2, 6);
            Console.WriteLine();
            Table(MySin, -2, 2);
            Console.ReadLine();

        }
    }
}
