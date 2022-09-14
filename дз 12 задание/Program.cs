using System;

namespace дз_12_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери фигуру (треугольник, четырехугольник, круг)");
            string form = Console.ReadLine();
            Console.WriteLine("Выбери что найти (площадь или периметр)");
            string type = Console.ReadLine();
            double sum = MyMethod(form, type);
            if (sum != 0)
            {
                Console.WriteLine($"Ответ: {sum}");
            }
            else
            {
                Console.WriteLine($"что то пошло не так :(");
            }

        }
        static double MyMethod(string form, string type)
        {
            if (form == "треугольник")
            {
                if (type == "площадь")
                {
                    Console.WriteLine("Введи высоту треугольника");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи основание треугольника");
                    double a = double.Parse(Console.ReadLine());
                    double sum = a * 0.5 * h;
                    return sum;
                }

                if (type == "периметр")
                {
                    Console.WriteLine("Введи сторону треугольника");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи сторону треугольника");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи сторону треугольника");
                    double a3 = double.Parse(Console.ReadLine());
                    double sum = a + a2 + a3;
                    return sum;
                }

            }
            if (form == "четырехугольник")
            {
                if (type == "площадь")
                {
                    Console.WriteLine("Введи сторону четырехугольника");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи другую сторону четырехугольника");
                    double a2 = double.Parse(Console.ReadLine());
                    double sum = a * a2;
                    return sum;

                }
                if (type == "периметр")
                {
                    Console.WriteLine("Введи сторону четырехугольника");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи другую сторону четырехугольника");
                    double a2 = double.Parse(Console.ReadLine());
                    double sum = a * 2 + a2 * 2;
                    return sum;
                }
            }
            if (form == "круг")
            {
                if (type == "площадь")
                {
                    Console.WriteLine("Введи радиус круга");
                    double r = double.Parse(Console.ReadLine());
                    double sum = Math.PI * r * r;
                    return sum;
                }
                if (type == "периметр")
                {
                    Console.WriteLine("Введи радиус круга");
                    double r = double.Parse(Console.ReadLine());
                    double sum = Math.PI * r * 2;
                    return sum;
                }
            }
            return 0;


        }
            
    }
}
