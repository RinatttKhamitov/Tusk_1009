using System;

namespace дз_7_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой X?: ");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine($"cos(x) = {Math.Cos(angle)}");
        }
    }
}
