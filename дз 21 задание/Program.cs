using System;

namespace дз_21_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"из прямоугольника с размерами 543 х 130 мм можно отрезать {(543 - (543.0 % 130.0)) / 130} квадратов со стороной 130 мм ");
        }
    }
}
