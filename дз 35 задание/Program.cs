using System;
using System.Threading;

namespace дз_35_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            while (true)
            {
                string hi = Console.ReadLine();
                if (hi.Contains("привет") || hi.Contains("Привет") || hi.Contains("прив") || hi.Contains("Прив"))
                {
                    Console.WriteLine("Как тебя завут?");
                    name = Console.ReadLine();
                    break;
                }
            }
            Console.WriteLine($"Привет, {name}");
            while (true)
            {
                string secret = Console.ReadLine();
                if (secret.Contains("знаешь") & secret.Contains("тайной") & (secret.Contains("комнате") || secret.Contains("комнате?")))
                {
                    Console.WriteLine("Да");
                    break;
                }
            }
            while (true)
            {
                string question = Console.ReadLine();
                if (question.Contains("можешь") & (question.Contains("рассказать") || question.Contains("рассказать?")))
                {
                    Console.WriteLine("Нет");
                    break;
                }
            }
            Thread.Sleep(5000);
            Console.WriteLine("");
            Random rnd = new Random();
            int value = rnd.Next(0, 3);
            if (value == 0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (value == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (value == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (value == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("Но могу показать");
        }
    }
}
