using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.

*/
namespace IntegerArrayWClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = MyArray.RandomIntArray(20,-10000,10000);
            MyArray.Print(arr);
            Console.WriteLine($"total pairs {MyArray.CountPairs(arr)}");
            Console.WriteLine();

            MyArray.Save("Array.txt", arr);
            try
            {
                int[] arrLoaded = MyArray.Load("Array.txt");
                MyArray.Print(arrLoaded);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
