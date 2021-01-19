using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Avdeev Roman
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
возвращает минимум через параметр.
*/
namespace MinFunc
{
    public delegate double func(double x);
    class Program
    {
        public static void SaveFunc(string fileName,func f, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName,out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            int len = (int)fs.Length / sizeof(double);
            double[] res = new double[len];
            for (int i = 0; i < len; i++)
            {
                d = bw.ReadDouble();
                res[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return res;
        }
        static void Main(string[] args)
        {
            List<func> functions = new List<func>() { Math.Sin, Math.Cos, Math.Sqrt, Math.Log, Math.Exp };
            Console.WriteLine("Choose function by typing number: 1:Sin, 2:Cos, 3:Sqrt, 4:Log, 5:Exp");
            int choose = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Enter the range [a,b]");
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter step h=");
            double h = Convert.ToDouble(Console.ReadLine());
            SaveFunc("data.bin",functions[choose], a,b,h);
            double min;
            var r = Load("data.bin", out min);
            Console.WriteLine($"min= {min}");
            foreach (var item in r)
            {
                Console.WriteLine($"f({a}) = {item}");
                a += h;
            }

            Console.ReadKey();
        }

    }
}
