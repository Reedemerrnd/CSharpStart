using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
 * Дан  целочисленный  массив  из 20 элементов.  
 * Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
 * Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, 
 * в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. 
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
*/
namespace IntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10000, 10000);
            }
            Print(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i - 1] % 3 != 0 ||
                    arr[i] % 3 != 0 && arr[i - 1] % 3 == 0)
                    count++;

            }
            Console.WriteLine($"total pairs {count}");

            Console.ReadKey();
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
