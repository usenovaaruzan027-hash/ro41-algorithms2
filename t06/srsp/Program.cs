using System;

namespace ArrayOpsApp
{
    public static class ArrayOps
    {
        // 1. Сумма элементов массива
        public static int Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        // 2. Индекс первого минимального элемента (начальное значение из массива)
        public static int IndexOfMin(int[] a)
        {
            if (a == null || a.Length == 0) return -1;

            int minIndex = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        // 3. Количество элементов больше x
        public static int CountGreater(int[] a, int x)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > x)
                {
                    count++;
                }
            }
            return count;
        }

        // 4. Разворот массива на месте
        public static void Reverse(int[] a)
        {
            if (a == null || a.Length <= 1) return;

            int n = a.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = temp;
            }
        }
    }

    class Program
    {
        static void TestArray(int[] originalArray, int x)
        {
            // Создаем копию массива, чтобы вывести исходный и перевернутый отдельно
            int[] a = (int[])originalArray.Clone();

            Console.WriteLine($"Исходный массив: [{string.Join(", ", a)}]");
            Console.WriteLine($"Сумма (Sum): {ArrayOps.Sum(a)}");
            Console.WriteLine($"Индекс минимума (IndexOfMin): {ArrayOps.IndexOfMin(a)}");
            Console.WriteLine($"Элементов больше {x} (CountGreater): {ArrayOps.CountGreater(a, x)}");

            ArrayOps.Reverse(a);
            Console.WriteLine($"Массив после Reverse: [{string.Join(", ", a)}]");
            Console.WriteLine(new string('-', 35));
        }

        static void Main(string[] args)
        {
            int x = 2; // Значение x по условию задачи

            TestArray(new int[] { 4, 1, 7, 3, 9 }, x);
            TestArray(new int[] { 5 }, x);
            TestArray(new int[] { -2, -7, -4 }, x);
            TestArray(new int[] { 2, 2, 2 }, x);
        }
    }
}