using System;

namespace _2_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи два числа");
            Console.Write("Первое число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
                Console.WriteLine("на ноль делить нельзя");
            else
            {
                Console.WriteLine($"{num} / {num2} = {num / num2}");
            }

            
        }
    }
}
