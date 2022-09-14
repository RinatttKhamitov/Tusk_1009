using System;

namespace дз_15_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine($"1 число = {rnd.Next()}");
            Console.WriteLine($"2 число = {rnd.Next()}");
            Console.WriteLine($"3 число = {rnd.Next()}");
            Console.WriteLine($"4 число = {rnd.Next()}");
        }
    }
}
