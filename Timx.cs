namespace Bài_2
{
    class Program
    {
        static int TKNhiPhan(int[] a, int left, int right, int x)
        {
            if (left > right)
                return -1;
            int mid = (left + right) / 2;
            if (a[mid] == x)
                return mid;
            else if (x < a[mid])
            {
                return TKNhiPhan(a, left, mid - 1, x);

            }
            else
            {
                return TKNhiPhan(a, mid + 1, right, x);
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Mời nhập n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Mảng vừa được nhập là ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i],3}");
            }
            Console.Write("\nMời nhập x = ");
            int x = int.Parse(Console.ReadLine());
            var kq = TKNhiPhan(a, 0, n - 1, x);
            if (kq == -1)
            {
                Console.Write($"{x} không tim thấy vị trí");
            }
            else
                Console.Write($"{x} ở vị trí {kq}");
        }
    }
}