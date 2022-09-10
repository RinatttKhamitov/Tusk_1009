using System;
using System.Collections.Generic;

namespace _3_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            {
                "а", "б", "в", "г", "д","е","ё","ж", "з", "и", "й", "к","л","м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э","ю", "я"
            };
            Console.Write("Введи букву: ");
            string str = Console.ReadLine();
            int index = myList.FindIndex(a => a.Contains(str));
            Console.WriteLine($"Следующая буква: {myList[index + 1]}");
        }
    }
}
