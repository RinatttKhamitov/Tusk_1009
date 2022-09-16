using System;

namespace дз_32_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи первый член прогрессии");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи второй член прогрессии");
            int a2 = int.Parse(Console.ReadLine());
            int d = a2 - a1;
            Console.WriteLine("Введи номер прогрессии");
            int n = int.Parse(Console.ReadLine());
            int an = a1 + (n - 1) * d;
            Console.WriteLine($"Ответ: {an}");

        }
    }
}
