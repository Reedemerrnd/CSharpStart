using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(2,3);
            f1.Print();
            Fraction f2 = new Fraction(2, -8);
            f2.Print();

            Fraction f3 = Fraction.Sum(f1, f2);
            Console.WriteLine(f3.DecimalView);
            f3.Print();

            f3 = Fraction.Substract(f1, f2);
            f3.Print();

            f3 = Fraction.Multiply(f1, f2);
            f3.Print();

            f3 = Fraction.Divide(f1, f2);
            f3.Print();

            f3.Simplify();
            f3.Print();
            Console.ReadLine();
        }
    }
}
