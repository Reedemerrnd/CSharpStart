using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) *Сделать задание, только вывод организовать в центре экрана.
    в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
*/
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Роман";
            string surname = "Авдеев";
            string city = "Ростов-На-Дону";
            //Вариант а)
            Console.WriteLine("Привет! Меня зовут {0} {1}. Я из города {2}.", name, surname, city);
            Console.ReadLine();

            //Вариант б)
            Console.Clear();
            string message = "Привет! Меня зовут " + name + " " + surname + ". Я из города " + city + ".";
            int centerX = Console.WindowWidth / 2 - message.Length / 2;
            int centerY = Console.WindowHeight / 2 - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine(message);
            Console.ReadLine();
            Console.Clear();

            //Вариант в)
            ConsoleMethods.Print(message, "center");
            ConsoleMethods.Pause();

        }
    }
}
