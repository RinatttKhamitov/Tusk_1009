using System;

namespace дз_3_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 случайные числа");
            Random rnd = new Random();
            for (int i = 0; i < 4; i ++)
            {
                Console.WriteLine(rnd.Next());
            }
        }
    }
}
