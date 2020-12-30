using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Авдеев Роман
 * Реализовать библиотеку с классом для работы с двумерным массивом. 
 * Реализовать конструктор, заполняющий массив случайными числами. 
 * Создать методы, которые возвращают сумму всех элементов массива, 
 * сумму всех элементов массива больше заданного,
 * свойство, возвращающее минимальный элемент массива, 
 * свойство, возвращающее максимальный элемент массива, 
 * метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
**в) Обработать возможные исключительные ситуации при работе с файлами.
*/
namespace MyArrayLib
{
    public class Matrix
    {
        int[,] matrix;
        int rows;
        int columns;

        public Matrix(int rows, int columns,int max)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
            Random r = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next(max);
                }

        }
        public Matrix(string path)
        {
            Load(path);
        }
        public int Max 
        {
            get
            {
                int max = matrix[0, 0];
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                    {
                        if (matrix[i, j] > max) max = matrix[i, j];
                    }
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = matrix[0, 0];
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                    {
                        if (matrix[i, j] < min) min = matrix[i, j];
                    }
                return min;
            }
        }
        public void Save(string path)
        {
            string[] temp = new string[rows];
            string tempstr = String.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tempstr += String.Format($"{matrix[i, j].ToString()} ");
                }
                temp[i] = tempstr.TrimEnd(' ');
                tempstr = String.Empty;
            }
            File.WriteAllLines(path, temp);
        }
        private void Load(string path)
        {
            try
            {
                string[] temp = File.ReadAllLines(path);
                string[] tmpRows = temp[0].Split(' ');
                rows = temp.Length;
                columns = tmpRows.Length;
                matrix = new int[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    tmpRows = temp[i].Split(' ');
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(tmpRows[j]);
                    }

                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void IndexOfMax(ref int row,ref int column)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == Max)
                    {
                        row = i+1;
                        column = j+1;
                    }
                }
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];
                }
            return sum;
        }
        public int SumFrom(int min)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i,j]>min) sum += matrix[i, j];
                }
            return sum;
        }
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i,j],4}");
                }
                Console.WriteLine();
            }
        }

    }
}
