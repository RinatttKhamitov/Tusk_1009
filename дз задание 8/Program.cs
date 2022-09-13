using System;

namespace дз_задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа находит периметр через основания и высоту.");
            Console.Write("Большее основание: ");
            int main = int.Parse(Console.ReadLine());
            Console.Write("Меньшее основание: ");
            int main2 = int.Parse(Console.ReadLine());
            Console.Write("высота трапеции: ");
            int h = int.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((main - main2) / 2, 2) + Math.Pow(h, 2));
            Console.WriteLine($"периметр трапеции: {main + main2 + 2 * a}");
        }
    }
}
