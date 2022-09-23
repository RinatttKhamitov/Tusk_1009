using System;

namespace TooMuch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. приветствует пользователя по имени");
            Console.Write("Привет как тебя завут?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");

        }
    }
}
