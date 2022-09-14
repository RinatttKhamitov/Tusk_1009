using System;

namespace дз_22_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи трехзначное  число: ");
            string num = Console.ReadLine();
            num = (num[2] + String.Empty) + (num[1] + String.Empty) + (num[0] + String.Empty);
            Console.Write(num);

        }
    }
}
