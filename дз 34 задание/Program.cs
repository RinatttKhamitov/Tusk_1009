using System;

namespace дз_34_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери а или б");
            string ab = Console.ReadLine();
            if (ab == "а" || ab == "А")
            {
                Console.Write("Как тебя завут?: ");
                Console.WriteLine(Console.ReadLine());
            }
            if (ab == "б" || ab == "Б")
            {
                Console.Write("Как тебя завут?: ");
                Console.WriteLine($"Привет, {Console.ReadLine()}");
            }
        }
    }
}
