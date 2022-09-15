using System;

namespace дз_31_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            // A*X3 + B*X2 + C*X + D = 0
            int A = 5;
            int B = 1;
            int C = 20;
            int D = 4;
            for (int i = -100; i < 100; i++)
            {
                if (((A * Math.Pow(i, 3)) - (B * Math.Pow(i, 2)) - ( C * i) + D) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
