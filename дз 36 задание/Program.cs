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
            int c = 0;
            for (int i = 0; i < str.Length; i ++)
            {
                if (i % 2 != 0)
                {

                    c += (int)Char.GetNumericValue(str[i]);
                }
            }
            c = c * 3;
            int nc = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {

                    nc += (int)Char.GetNumericValue(str[i]);
                }
            }
            c += nc;
            string laststr = c.ToString();
            int lastnum = 10 - (int)Char.GetNumericValue(laststr[laststr.Length - 1]);
            Console.WriteLine($"Число EAN13 = {str}{lastnum}");

            Console.Write("Введи 12 цифр: ");
            value = long.Parse(Console.ReadLine());
            str = value.ToString();
            c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {

                    c += (int)Char.GetNumericValue(str[i]);
                }
            }
            c = c * 3;
            nc =0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {

                    nc += (int)Char.GetNumericValue(str[i]);
                }
            }
            c += nc;
            laststr = c.ToString();
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
