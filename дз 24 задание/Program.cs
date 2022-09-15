using System;

namespace дз_24_задание
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }
            static void Main(string[] args)
        {
            Console.WriteLine("Введи четырехзначное число");
            string num = Console.ReadLine();
            string revnum = ReverseString(num);
            Console.WriteLine(revnum);
            num = (num[1] + String.Empty) + (num[0] + String.Empty) + (num[3] + String.Empty) + (num[2] + String.Empty);
            while (num.Contains("0"))
            {
                if (num[0].ToString() == "0")
                {
                    num = num.Remove(0, 1);
                    Console.WriteLine(num);
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(num);

        }
    }
}
