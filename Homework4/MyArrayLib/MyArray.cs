using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
 *  Дописать класс для работы с одномерным массивом. 
 * Реализовать конструктор, создающий массив определенного размера и 
 * заполняющий массив числами от начального значения с заданным шагом. 
 * Создать свойство Sum, которое возвращает сумму элементов массива,
 * метод Inverse, возвращающий новый массив с измененными знаками у 
 * всех элементов массива (старый массив, остается без изменений),  
 *метод Multi, умножающий каждый элемент массива на определённое число,
 * свойство MaxCount, возвращающее количество максимальных элементов. 
б)**Создать библиотеку содержащую класс для работы с массивом. 
Продемонстрировать работу библиотеки
е) ***Подсчитать частоту вхождения каждого элемента в массив 
(коллекция Dictionary<int,int>)
*/
namespace MyArrayLib
{
    public class MyArray
    {
        int[] arr;
        int size;

        public int Length { get => size; }
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
        public MyArray(int size = 0)
        {
            arr = new int[size];
            this.size = size;
        }
        public MyArray(int size, int start, int step)
            :this (size)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = start;
                start += step;
            }
        }
        public MyArray(int[] arr)
            :this(arr.Length)
        {
            size = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }

        public Dictionary<int,int> MakeDic()
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                if (numCount.ContainsKey(arr[i])) break;
                else
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (arr[i] == arr[j]) count++;
                    } 
                }
                numCount.Add(arr[i], count);
                count = 1;
            }
            return numCount;
        }
        public void ShowDic()
        {
            Dictionary<int, int> numCount = MakeDic();
            foreach (KeyValuePair<int, int> kvp in numCount)
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < size; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }
        public void Multi(int n)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] *= n;
            }
        }
        public MyArray Inverse()
        {
            MyArray res = new MyArray(size);
            for (int i = 0; i < size; i++)
            {
                res[i] = -arr[i];
            }
            return res;
        }
        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = arr.Max();
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] == max) count++;
                }
                return count;
            }
        }

        public static int CountPairs(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i - 1] % 3 != 0 ||
                    arr[i] % 3 != 0 && arr[i - 1] % 3 == 0)
                    count++;
            }
            return count;
        }
        public void Load(string path)
        {
            string[] temp;
            if (File.Exists(path))
            {
                temp = File.ReadAllLines(path);
                size = temp.Length;
                Array.Resize(ref arr,temp.Length);
                for (int i = 0; i < temp.Length; i++)
                {
                    arr[i] = int.Parse(temp[i]);
                }
            }
            else throw new FileNotFoundException();
        }
        public void Save (string path)
        {
            File.WriteAllLines(path,
                                Array.ConvertAll(arr, Convert.ToString)
                                );
        }
        public void RandomIntArray(int size, int min, int max)
        {
            this.size = size;
            Random r = new Random();
            Array.Resize(ref arr, size);
            for (int i = 0; i < size; i++)
                arr[i] = r.Next(min, max);

        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
