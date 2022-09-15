using System;

namespace дз_26_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько часов?");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько минут?");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько секунд?");
            int second = int.Parse(Console.ReadLine());
            int time = (hours * 3600) + (minutes * 60) + second;
            double angle = time * 2;
            angle = angle * 360 / 86400;
            if (angle > 360)
            {
                angle -= 360;
            }
            Console.WriteLine($"угол = {angle}");
            

        }
    }
}
