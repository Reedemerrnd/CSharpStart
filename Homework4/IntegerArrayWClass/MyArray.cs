using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Авдеев Роман
// статический класс задание 2
namespace IntegerArrayWClass
{
    static class MyArray
    {
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
        public static int[] Load(string path)
        {
            string[] temp;
            if (File.Exists(path))
            {
                temp = File.ReadAllLines(path);
                int[] arr = new int[temp.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    arr[i] = int.Parse(temp[i]);
                }
                return arr;
            }
            else throw new FileNotFoundException();
        }
        public static void Save (string path,int[]arr)
        {
            File.WriteAllLines(path,
                                Array.ConvertAll(arr, Convert.ToString)
                                );
        }
        public static int[] RandomIntArray(int size, int min, int max)
        {
            Random r = new Random();
            int[] res = new int[size];
            for (int i = 0; i < size; i++)
                res[i] = r.Next(min, max);
            return res;

        }
        public static void Print (int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
