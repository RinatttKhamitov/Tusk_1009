using System;

namespace дз_30_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи число: ");
            int num = int.Parse(Console.ReadLine());
            int intData = (int)Math.Sqrt(num);
            int howMuch = 0;
            for (int i = 1; i < intData + 1 ; i++)
            {
                if (num % i == 0)
                {
                    howMuch++;
                }
            }
            Console.WriteLine($"Число {num} имеет {howMuch + 1} делителей");
        }
    }
}
