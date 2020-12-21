using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class ConsoleMethods
    {
        public static void Print (string message, int x , int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }
        public static void Print (string message, string center)
        {
            if (center=="center")
            {
                int centerX = Console.WindowWidth / 2 - message.Length / 2;
                int centerY = Console.WindowHeight / 2 - 1;
                Console.SetCursorPosition(centerX, centerY);
                Console.WriteLine(message);
            }
        }
        public static void Pause()
        {
            Console.ReadLine();
        }
        public static string AskForStr(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }
        public static int AskForInt(string message)
        {
            Console.WriteLine(message);
            return Int32.Parse(Console.ReadLine());
        }
        public static double AskForDouble(string message)
        {
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
