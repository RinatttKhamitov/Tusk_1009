using System;

namespace дз_9_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стоимость 1 кг конфет = 20 руб, печенья = 35 руб и яблок = 40 руб");
            Console.Write("сколько купил кг конфет?: ");
            int sweets = int.Parse(Console.ReadLine());
            Console.Write("сколько купил кг печенья?: ");
            int cookies = int.Parse(Console.ReadLine());
            Console.Write("сколько купил кг яблок?: ");
            int apples = int.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки = {sweets * 20 + cookies * 35 + apples * 40}");
        }
    }
}
