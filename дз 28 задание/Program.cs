using System;

namespace дз_28_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи 3 числа");
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int num2 = Math.Abs(int.Parse(Console.ReadLine()));
            int num3 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine($"число меньшее по модулю = {Math.Min(num, Math.Min(num2, num3))}");
        }
    }
}
