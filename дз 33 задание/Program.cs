using System;

namespace дз_33_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ты пенсионер?: ");
            string p = Console.ReadLine();
            Console.Write("Ты студент?: ");
            string s = Console.ReadLine();
            Console.Write("Ты не трудоустроен?: ");
            string t = Console.ReadLine();
            if ((p == "Да" || p == "да") & (s == "Да" || s == "да"))
            {
                Console.WriteLine("ты не сможешь получть кредит");
            }
            else
            {
                if (((p == "Да" || p == "да") || (s == "Да" || s == "да")) & (t == "Да" || t == "да"))
                {
                    Console.WriteLine("ты сможешь получть кредит");
                }
                else
                {
                    Console.WriteLine("ты не сможешь получть кредит");
                }
            }
        }
    }
}
