using System;

namespace bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so ptu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang a: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            int min = a[0];
            int max = a[0];
            MaxMin(a, 0, n - 1, ref min, ref max);
            Console.WriteLine($"\nMin = {min}");
            Console.WriteLine($"Max = {max}");
        }
        static void MaxMin(int[] a, int dau, int cuoi, ref int min, ref int max)
        {
            int min1 = a[dau];
            int min2 = a[dau];
            int max1 = a[dau];
            int max2 = a[dau];
            if (dau == cuoi)
            {
                min = a[dau];
                max = a[dau];
            }
            else
            {
                var k = (dau + cuoi) / 2;
                MaxMin(a, dau, k, ref min1, ref max1);
                MaxMin(a, k + 1, cuoi, ref min2, ref max2);
                if (min1 < min2) min = min1;
                else min = min2;
                if (max1 > max2) max = max1;
                else max = max2;
            }
        }
    }
}