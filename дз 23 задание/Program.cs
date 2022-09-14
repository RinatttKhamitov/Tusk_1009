using System;

namespace дз_23_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи число n < 999: ");
            string num = Console.ReadLine();
            Console.WriteLine($"сотен: {num[num.Length - 3]}");
            Console.WriteLine($"тысяч: {num[num.Length -4]}");

        }
    }
}
