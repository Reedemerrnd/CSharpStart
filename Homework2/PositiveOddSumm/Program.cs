using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Авдеев Роман
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
namespace PositiveOddSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int n = 0;
            do
            {
                Console.WriteLine("Enter number");
                n = int.Parse(Console.ReadLine());
                if (n > 0 && n % 2 != 0)
                    sum += n;
            }
            while (n != 0);

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
