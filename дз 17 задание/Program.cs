using System;

namespace дз_17_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число 1 = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Число 2 = ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write($"среднее арифметическое = {(a + a2)/2}, среднее геометрическое = {Math.Sqrt(a*a2)}");

        }
    }
}
