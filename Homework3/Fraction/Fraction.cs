using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Авдеев Роман
 * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
***Добавить упрощение дробей.
**/
namespace Fraction
{
    class Fraction
    {
        private int denominator;
        private int divisor;

        public double DecimalView { get => (double)denominator / divisor; }      
        public int Divisor
        {
            get { return divisor; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                else if (value < 0)
                {
                    divisor = -value;
                    Denominator = -Denominator;
                }
                else
                    divisor = value;

            }
        }
        public int Denominator { get => denominator; set => denominator = value; }

        public Fraction(int den=0, int div=1)
        {
            try
            {               
                Denominator = den;
                Divisor = div;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.GetType().Name}: {e.Message}");
            }
        }

        public void Print()
        {
            Console.WriteLine($"{Denominator}/{Divisor}");
        }

        public void Simplify() //упрощение
        {
            int gcd = GreatestCommonDivisor(Denominator, Divisor);
            Denominator /= gcd;
            Divisor /= gcd;
        }

        public static Fraction Sum(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            //наименьшее общее кратное
            if (f1.Divisor != f2.Divisor)
            {

                int lcm = (Math.Abs(f1.Divisor * f2.Divisor))
                           / GreatestCommonDivisor(f1.Divisor, f2.Divisor);

                res.Denominator = (f1.Denominator * (lcm / f1.Divisor) +
                                   f2.Denominator * (lcm / f2.Divisor)
                                   );
                res.Divisor = lcm;

            }
            else
            {
               res.Denominator = f1.Denominator + f2.Denominator;
                res.Divisor = f1.Divisor;
            }           
            return res;
        }
        public static Fraction Substract(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            //наименьшее общее кратное
            if (f1.Divisor != f2.Divisor)
            {

                int lcm = (Math.Abs(f1.Divisor * f2.Divisor))
                           / GreatestCommonDivisor(f1.Divisor, f2.Divisor);

                res.Denominator = (f1.Denominator * (lcm / f1.Divisor) -
                                   f2.Denominator * (lcm / f2.Divisor)
                                   );
                res.Divisor = lcm;

            }
            else
            {
                res.Denominator = f1.Denominator - f2.Denominator;
                res.Divisor = f1.Divisor;
            }
            return res;
        }
        public static Fraction Multiply(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction(f1.Denominator*f2.Denominator,f1.Divisor*f2.Divisor);
            return res;
        }
        public static Fraction Divide(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction(f1.Denominator * f2.Divisor, f1.Divisor * f2.Denominator);
            return res;
        }
        public static int GreatestCommonDivisor (int a, int b)
            //наибольшей общий делитель
        {
            int res;
            int t1 = Math.Max(a, b);
            int t2 = Math.Min(a, b);
            while (true)
            {
                while (t1 >= t2)
                {
                    t1 = t1 - t2;
                }
                if (t1 == 0)
                {
                    res = t2;
                    break;
                }
                else
                {
                    res = t1;
                    t1 = t2;
                    t2 = res;
                }
            }

            return res;
        }
    }
}
