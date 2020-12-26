using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Авдеев Роман
/*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
*/
namespace PositiveOddSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int n;

            do
            {
                Console.WriteLine("Enter number");
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    if (n > 0 && n % 2 != 0)
                        sum += n;
                }
                else n=1;

            }

            while (n != 0);

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
