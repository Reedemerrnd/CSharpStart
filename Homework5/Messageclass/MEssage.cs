using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*Avdeev Roman
 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. 
В качестве параметра в него передается массив слов и текст, 
в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
Здесь требуется использовать класс Dictionary.
*/
namespace Messageclass
{
    static class Message
    {
        public static void MaxLengthWords (string text,int length) // вывод слов длинной до заданной
        {
            string pattern; 
            if (length<3) pattern= @"\b(\w{1," + length + @"})\b";
            else pattern = @"\b(\w+-?\w{0," + length + @"})\b";
            Regex myReg = new Regex(pattern);
            MatchCollection matches = myReg.Matches(text);
            foreach (Match m in matches) Console.WriteLine(m.Value);
        }
        public static void DeleteByEndSymbol(ref string text, char c) // удаление слов по последнему символу
        {
            string pattern = @"\s\b(\w+-?\w+["+c+@"])\b";
            Regex myReg = new Regex(pattern);
            text = myReg.Replace(text, string.Empty);
        }
        private static string[] GetWords(string text) //разбивает текст на слова 
        {
            string pattern = @"\b(\w+-?\w+)\b";
            Regex myReg = new Regex(pattern);
            MatchCollection words = myReg.Matches(text);
            string[] res = new string[words.Count];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = words[i].ToString();
            }
            return res;
        }
        public static string LongestWord(string text) // самое длинное слово
        {
            string[] words = GetWords(text);
            string max = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max.Length) max = words[i];
            }
            return max;
        }
        public static string LongestWordString(string text) // строка саммых длинных слов
        {
            int len = LongestWord(text).Length;
            string[] words = GetWords(text);
            StringBuilder str = new StringBuilder(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == len) str.Append(words[i] + ' ');
            }
            return str.ToString().Trim();
        }
        public static void Dict(string[] words, string text) // частотный анализ
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] textArr = GetWords(text);
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < textArr.Length; j++)
                {
                    if (words[i] == textArr[j]) count++;
                }
                dict.Add(words[i], count);
                count = 0;
            }
            foreach (KeyValuePair<string,int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
