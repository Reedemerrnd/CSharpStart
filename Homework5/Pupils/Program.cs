using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;
/*Avdeev Roman
 * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
 * В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
<Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, 
которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
*/
namespace Pupils
{
    struct Pupils
    {
        public string name;
        public double avgGrade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = File.ReadAllLines("pupils.txt");
            string[] s;
            int size = int.Parse(str[0]);
            Pupils[] ppl = new Pupils[size];
            for (int i = 1; i < size+1; i++)
            {
                s = str[i].Split(' ');
                ppl[i-1].name = $"{s[0]} {s[1]}";
                ppl[i-1].avgGrade = AvgValue(s[2], s[3], s[4]);
            }
            double grade = ThirdMinVal(ppl);
            for (int i = 0; i < ppl.Length; i++)
            {
                if (ppl[i].avgGrade <= grade) Console.WriteLine($"{ppl[i].name} {ppl[i].avgGrade}");
            }
            {

            }
            Console.ReadLine();
        }
        public static double AvgValue(string s1, string s2, string s3)
        {
            int n1 = int.Parse(s1);
            int n2 = int.Parse(s2);
            int n3 = int.Parse(s3);
            double res = (double)(n1 + n2 + n3) / 3;
            return res;
        }
        public static double ThirdMinVal(Pupils[] ppl)
        {
            double min1 = ppl[0].avgGrade;
            double min2 = ppl[0].avgGrade;
            double min3 = ppl[0].avgGrade;
            for (int i = 1; i < ppl.Length; i++)
            {
                double val = ppl[i].avgGrade;
                if (val < min1)
                {
                    min3 = min2;
                    min2 = min1;
                    min1 = val;
                }
                else if (val < min2 && val>min1)
                {
                    min3 = min2;
                    min2 = val;
                }
                else if(val < min3 && val>min2)
                {
                    min3 = val;
                }
            }
            return min3;
        }
    }


}
