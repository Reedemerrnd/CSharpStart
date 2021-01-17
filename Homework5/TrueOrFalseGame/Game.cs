using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Avdeev Roman
 * Написать игру «Верю. Не верю». 
 * В файле хранятся вопрос и ответ, правда это или нет. 
 * Например: «Шариковую ручку изобрели в древнем Египте», «Да». 
 * Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. 
 * Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ.
 */
namespace TrueOrFalseGame
{
    class Game
    {
        int score;
        string path;
        int size;
        string[][] questions;
        public int Score { get; }
        private Game(string path, int size)
        {
            this.path = path;
            questions = new string[size][];
            this.size = size;
            score = 0;
        }
        public static void Start(int questNumber)
        {
            if (questNumber >= 21) questNumber = 21;
            Game newGame = new Game("questions.txt",questNumber);
            newGame.GetRandomQuestions(newGame.path);
            newGame.RunGame();


        }

        private void RunGame()
        {
            string answer;
            Console.WriteLine("ответы только да или нет");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(questions[i][0]);
                answer = Console.ReadLine().ToLower();
                if (answer == questions[i][1])
                {
                    score++;
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
              
            }
            Console.WriteLine($"Total score: {score}");
        }


        private void GetRandomQuestions(string path)
        {
            string[] temp = File.ReadAllLines(path);
            Random rng = new Random();
            int n;
            List<int> rolls = new List<int>();
            for (int i = 0; i < size; i++)
            {
                while (true)
                {
                    n = rng.Next(0, temp.Length);
                    if (!rolls.Contains(n))
                    {
                        rolls.Add(n);
                        break;
                    }
                }
                questions[i] = temp[n].Split('=');
            }

        }

    }
}
