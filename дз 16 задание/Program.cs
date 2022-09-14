using System;

namespace дз_16_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи три числа коэффициенты уравнения");
            Console.Write("число 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("число 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("число 3: ");
            int c = int.Parse(Console.ReadLine());

            double D = (b * b) - (4 * a * c);
            D = Math.Sqrt(D);
            double x1 = (-b + D) / 2 * a;
            double x2 = (-b - D) / 2 * a;
            Console.WriteLine($"первый корень {x1} второй корень {x2}")
        }
    }
}
