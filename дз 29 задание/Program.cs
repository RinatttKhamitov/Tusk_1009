using System;

namespace дз_29_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи 3 числа");
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"меньшее число = {Math.Min(num, Math.Min(num2, num3))}");
            Console.WriteLine($"большее число = {Math.Max(num, Math.Max(num2, num3))}");
        }
    }
}
