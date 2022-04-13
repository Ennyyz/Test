using System;
using System.Text;

namespace Git
{
    class Program
    {
        //Viết chương trình C# để nhập một ma trận, sau đó sắp xếp tăng dần của ma trận và in kết quả trên màn hình.
        //test github
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng: "); int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: "); int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int[] b = new int[100];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhập phần tử thứ [{0},{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mảng vừa mới nhập: ");
            XuatMang(a);
            Console.WriteLine("Chưa sắp xếp: ");
            MangSX(a, m, n, b);
            Console.WriteLine();
            Console.WriteLine("Đã sắp xếp: ");
            SapXep(b, m, n);

            XuatMang2(b, m, n);
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void MangSX(int[,] a, int m, int n, int[] b)
        {
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[k] = a[i, j];
                    Console.Write("{0,3}", b[k]);
                    k++;
                }
            }
        }

        static void SapXep(int[] b, int m, int n)
        {
            for (int i = m * n; i > 0; i--)    //2*2;4>0;4
            {
                for (int j = 0; j < i; j++)  //0-1;1<4;1
                {
                    if (b[j] < b[j + 1])
                    {
                        int temp;
                        temp = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = temp;
                    }
                }
            }
        }
        static void XuatMang2(int[] b, int m, int n)
        {
            for (int i = 1; i < m * n + 1; i++)
            {
                Console.Write("{0,3}", b[i]);
            }
            Console.WriteLine();
        }
    }
}