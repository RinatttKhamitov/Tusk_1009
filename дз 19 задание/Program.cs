using System;

namespace дз_19_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери способ А или Б");
            Console.Write("а = ");
            var a = Console.ReadLine();
            Console.Write("b = ");
            var b = Console.ReadLine();
            Console.Write("c = ");
            var c = Console.ReadLine();
            string ab = Console.ReadLine();
            if (ab == "A" || ab == "А")
            {
                var d = b;
                b = c;
                c = a;
                a = d;
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }
            if (ab == "B" || ab == "В")
            {
                var d = b;
                b = a;
                a = c;
                c = d;
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }
        }
    }
}
