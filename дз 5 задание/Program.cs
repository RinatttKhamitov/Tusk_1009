using System;

namespace дз_5_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторну квадрата");
            int square = int.Parse(Console.ReadLine());
            Console.WriteLine($"периметр квадрата = {square * 4}");

        }
    }
}
