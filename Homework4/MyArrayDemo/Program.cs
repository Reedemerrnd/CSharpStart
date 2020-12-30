using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArrayLib;
/* Авдеев Роман задание 3
Демонстрация библиотеки MyArrayLib класс MyArray
*/
namespace MyArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[] { 1, 2, 3, 4, 6, 7, 5, 7, 6, 7 };
            MyArray arr1 = new MyArray(temp);
            MyArray arr2 = new MyArray(arr1.Length);
            arr2 = arr1.Inverse();
            arr1.Print();
            arr2.Print();
            arr1.Multi(2);
            arr1.Print();
            Console.WriteLine(arr1.MaxCount);
            arr1.ShowDic();
            Console.ReadLine();
        }
    }
}
