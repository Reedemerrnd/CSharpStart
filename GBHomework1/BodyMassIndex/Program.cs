using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
*/
namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост в метрах");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вес в килограммах");
            double weight = Convert.ToDouble(Console.ReadLine());
            double ind = weight / (height * height);

            Console.WriteLine("Индекс массы тела равен {0:F}", ind);
            Console.ReadLine();

        }
    }
}
