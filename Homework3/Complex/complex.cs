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
    struct Complex
    {
        public double re;
        public double im;


        public Complex(double re, double im) : this()
        {
            this.re = re;
            this.im = im;
        }

        public void Print ()
        {
            string temp = String.Empty;

            if (re == 0) temp = $"";
            else temp = $"{re}";

            if (im == 0) temp += $"";
            else if (im > 0) temp += $" + {im}i";
            else temp += $" - {-im}i";
            Console.WriteLine(temp);
        }
        public static Complex Sum (Complex z1, Complex z2)
        {
            Complex res = new Complex(z1.re + z2.re, z1.im + z2.im);
            return res;
        }
        public static Complex Substract(Complex z1, Complex z2)
        {
            Complex res = new Complex(z1.re - z2.re, z1.im - z2.im);
            return res;
        }
        public static Complex Multiply(Complex z1, Complex z2)
        {
            Complex res = new Complex(z1.re*z2.re - z1.im*z2.im,
                                      z1.im*z2.re + z1.re*z2.im);
            return res;
        }
    }
}
