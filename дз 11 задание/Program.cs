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
            if (num.Contains("."))
                num = num.Replace(".", ",");
            double numericValue;
            bool isNumber = double.TryParse(num, out numericValue);
            if (isNumber == false)
            {
                Console.WriteLine("Число 1 строка");
            }

            if (num2.Contains("."))
                num2 = num2.Replace(".", ",");
            double numericValue2;
            bool isNumber2 = double.TryParse(num2, out numericValue2);
            if (isNumber2 == false)
            {
                Console.WriteLine("Число 2 строка");
            }
            else
            {
                double numericValue3 = numericValue;
                numericValue = numericValue2;
                numericValue2 = numericValue3;

                Console.WriteLine($"число 1 = {numericValue}, число 2 = {numericValue2}");
            }
        


        }
    }
}
