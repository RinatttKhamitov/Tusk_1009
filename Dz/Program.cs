using System;

namespace Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 3);
            if (value == 0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (value == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (value == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (value == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
        }
    }
}
