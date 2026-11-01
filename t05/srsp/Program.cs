using System;

namespace RecursionApp
{
    public static class Rec
    {
        // Метод для вычисления суммы цифр неотрицательного числа
        public static int DigitSum(int n)
        {
            // Базовый случай: если число состоит из одной цифры (меньше 10)
            if (n < 10)
            {
                return n;
            }

            // Шаг рекурсии: последняя цифра + сумма цифр оставшейся части числа
            return (n % 10) + DigitSum(n / 10);
        }

        // Метод для вычисления x в степени n (без Math.Pow)
        public static long Pow(int x, int n)
        {
            // Базовый случай: любое число в степени 0 равно 1
            if (n == 0)
            {
                return 1;
            }

            // Шаг рекурсии: x умножается на x в степени (n - 1)
            return x * Pow(x, n - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Проверка DigitSum
            Console.WriteLine($"DigitSum(0) = {Rec.DigitSum(0)}");
            Console.WriteLine($"DigitSum(7) = {Rec.DigitSum(7)}");
            Console.WriteLine($"DigitSum(12345) = {Rec.DigitSum(12345)}");
            Console.WriteLine($"DigitSum(1000) = {Rec.DigitSum(1000)}");

            Console.WriteLine();

            // Проверка Pow
            Console.WriteLine($"Pow(2, 0) = {Rec.Pow(2, 0)}");
            Console.WriteLine($"Pow(2, 10) = {Rec.Pow(2, 10)}");
            Console.WriteLine($"Pow(5, 3) = {Rec.Pow(5, 3)}");
            Console.WriteLine($"Pow(7, 1) = {Rec.Pow(7, 1)}");
        }
    }
}