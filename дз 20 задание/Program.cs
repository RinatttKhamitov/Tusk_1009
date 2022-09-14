using System;

namespace дз_20_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"полных часов прошло с начала суток: {DateTime.Now.Hour}");
            Console.WriteLine($"полных минут прошло с начала очередного часа: {DateTime.Now.Minute}");
            Console.WriteLine($"полных секунд прошло с начала очередной минуты: {DateTime.Now.Second}");
        }
    }
}
