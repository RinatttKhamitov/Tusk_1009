using System;

namespace дз_11_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи два числа");
            Console.Write("Число 1 = ");
            var num = Console.ReadLine();
            Console.Write("Число 2 = ");
            var num2 = Console.ReadLine();
            try
            {
                double intnum = double.Parse(num);
            }
            catch
            {
                if (num.Contains(','))
                {
                    num.Replace(',', '.');
                    try
                    {
                        double intnum = double.Parse(num);
                    }
                    catch
                    {
                        Console.WriteLine("Ты ввел строку");
                    }
                    finally
                    {
                        double intnum = double.Parse(num);
                    }
                }
                else
                {
                    string intnum = "строка";
                    Console.WriteLine("Ты ввел строку");
                }

            }
            finally
            {
                double intnum = double.Parse(num);
            }
            try
            {
                double intnum2 = double.Parse(num2);
            }
            catch
            {
                if (num.Contains(','))
                {
                    num.Replace(',', '.');
                    try
                    {
                        double intnum2 = double.Parse(num2);
                    }
                    catch
                    {
                        Console.WriteLine("Ты ввел строку");
                    }
                    finally
                    {
                        double intnum2 = double.Parse(num2);
                    }
                }
                else
                {
                    Console.WriteLine("Ты ввел строку");
                }

            }
            finally
            {
                double intnum = double.Parse(num);
                double intnum2 = double.Parse(num2);
                Console.WriteLine($"Число 2 = {intnum2}, число 1 = {intnum}");
            }
        }
    }
}
