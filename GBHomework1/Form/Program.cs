using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region
/* Авдеев Роман
    Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
    В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
*/
#endregion
namespace Form
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вес");
            double weight = Convert.ToDouble(Console.ReadLine());
            //вариант а
            Console.WriteLine("Привет, " + name + " " + surname + "! Вам "
                                + age + " лет(года). Ваш рост: " + height
                                + " и Ваш вес: " + weight + "."
                                );
            //вариант б
            Console.WriteLine(string.Format("Привет, " + name + " "
                                            + surname + "! Вам "
                                            + age + " лет(года). Ваш рост: "
                                            + height + " и Ваш вес: " + weight + ".")
                                            );
            //вариант в
            Console.WriteLine($"Привет, {name} {surname}! Вам {age} лет(года). Ваш рост: {height} и Ваш вес: {weight}.");
            Console.ReadLine();
        }
    }
}
