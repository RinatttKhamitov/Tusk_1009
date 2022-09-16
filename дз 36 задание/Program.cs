using System;

namespace дз_36_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Случайный EAN13");
            long value = LongRandom(10000000000, 999999999999, new Random());
            string str = value.ToString();
            int c = (int)Char.GetNumericValue(str[1]) + (int)Char.GetNumericValue(str[3]) + (int)Char.GetNumericValue(str[5]) + (int)Char.GetNumericValue(str[7]) + (int)Char.GetNumericValue(str[9]) + (int)Char.GetNumericValue(str[11]);
            c = c * 3;
            int nc = (int)Char.GetNumericValue(str[2]) + (int)Char.GetNumericValue(str[4]) + (int)Char.GetNumericValue(str[6]) + (int)Char.GetNumericValue(str[8]) + (int)Char.GetNumericValue(str[10]);
            c += nc;
            string laststr = c.ToString();
            int lastnum = 10 - (int)Char.GetNumericValue(laststr[laststr.Length - 1]);
            Console.WriteLine($"Число EAN13 = {str}{lastnum}");

            Console.Write("Введи 12 цифр: ");
            value = long.Parse(Console.ReadLine());
            str = value.ToString();
            c = (int)Char.GetNumericValue(str[1]) + (int)Char.GetNumericValue(str[3]) + (int)Char.GetNumericValue(str[5]) + (int)Char.GetNumericValue(str[7]) + (int)Char.GetNumericValue(str[9]) + (int)Char.GetNumericValue(str[11]);
            c = c * 3;
            Console.WriteLine(str);
            Console.WriteLine(c);
            nc = (int)Char.GetNumericValue(str[2]) + (int)Char.GetNumericValue(str[4]) + (int)Char.GetNumericValue(str[6]) + (int)Char.GetNumericValue(str[8]) + (int)Char.GetNumericValue(str[10]);
            c += nc;
            Console.WriteLine(nc);
            laststr = c.ToString();
            Console.WriteLine(laststr);
            lastnum = 10 - (int)Char.GetNumericValue(laststr[laststr.Length - 1]);
            Console.WriteLine($"Число EAN13 = {str}{lastnum}");


        }
        static long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

    }
}
