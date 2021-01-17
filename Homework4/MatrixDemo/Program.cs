using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyArrayLib;
// Авдеев Роман задание 5
// Демонстрация библиотеки MyArrayLib класс Matrix
namespace MatrixDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;
            Matrix m = new Matrix(5, 5, 20);
            m.Print();
            Console.WriteLine(m.Sum());
            Console.WriteLine(m.SumFrom(5));
            Console.WriteLine(m.Max);
            Console.WriteLine(m.Min);
            m.IndexOfMax(ref row, ref column);
            Console.WriteLine($"ind of max: {row},{column}");

            Console.WriteLine();
            m.Save("Matrix.txt");
            Matrix n = new Matrix("Matrix.txt");
            n.Print();

            Console.ReadKey();
        }
    }
}
