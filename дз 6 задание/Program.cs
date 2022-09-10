using System;

namespace дз_6_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"длина окружности = {2 * Math.PI * radius} и площадь круга = {Math.PI * Math.PI * radius}");
        }
    }
}
