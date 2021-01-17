using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messageclass
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "one когда-нибудь в аббревиатура когда-нибудь two three four five six, one: two! three? когда-нибудь three three";
            Message.MaxLengthWords(text, 14);
            Message.DeleteByEndSymbol(ref text, 'e');
            Console.WriteLine(text);
            Console.WriteLine(Message.LongestWord(text));
            Console.WriteLine(Message.LongestWordString(text));
            string[] words = { "one", "когда-нибудь", "four", "two" };
            Message.Dict(words, text);
            Console.ReadKey();
        }
    }
}
