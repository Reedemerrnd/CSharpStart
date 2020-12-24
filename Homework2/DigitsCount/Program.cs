using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Авдеев Роман
//Написать метод подсчета количества цифр числа.
namespace DigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitsCnt(100));//3
            Console.WriteLine(DigitsCnt(255462));//6
            Console.WriteLine(DigitsCnt(46541216));//8



            Console.ReadKey();
        }

        static int DigitsCnt(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count++;
                number = number / 10;
            }
            return count;
        }
    }
}
