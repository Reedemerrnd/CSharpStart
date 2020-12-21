using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**Авдеев Роман
 * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 * «Хорошим» называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 */
namespace GoodNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (i % DigitsSum(i) == 0)
                    count++;
            }
            
            Console.WriteLine(count);
            Console.WriteLine(DateTime.Now-start);

            Console.ReadKey();
        }
        static int DigitsSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum+=number%10;
                number = number / 10;
            }
            return sum;
        }
    }
}
