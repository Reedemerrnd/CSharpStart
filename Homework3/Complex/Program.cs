using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Авдеев  Роман
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex();
            Complex z2 = new Complex();
            Complex z3 = new Complex();
            bool exit = false;
            string choice = "n";
            do
            {
                switch (choice)
                {
                    case "n":
                        Console.Write("Enter z1 re: ");
                        z1.re = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter z1 im: ");
                        z1.im = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter z2 re: ");
                        z2.re = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter z2 im: ");
                        z2.im = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "show":
                        z1.Print();
                        z2.Print();
                        break;
                    case "+":
                        z3 = Complex.Sum(z1, z2);
                        z3.Print();
                        break;
                    case "-":
                        z3 = Complex.Substract(z1, z2);
                        z3.Print();
                        break;
                    case "*":
                        z3 = Complex.Multiply(z1, z2);
                        z3.Print();
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        break;
                }
                if (!exit)
                {
                    Console.Write("type: n - for new pair, exit - to exit, show - to show numbers or operations: + - *: ");
                    choice = Console.ReadLine();
                }
            } while (!exit);
            

            //Console.ReadKey();
        }
    }
}
