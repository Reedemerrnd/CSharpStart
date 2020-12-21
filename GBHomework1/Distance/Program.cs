using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
*/
namespace Distance
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите х1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите х2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //Вариант а)
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками = {0:F}", r);

            //Вариант б)
            Console.WriteLine("Тоже самое, но с помощью метода");
            r = TwoPointDistance(x1, y1, x2, y2);            
            Console.WriteLine($"Расстояние между точками = {r:F}");
            Console.ReadLine();
        }
      
        static double TwoPointDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
