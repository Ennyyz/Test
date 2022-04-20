using System;
using System.Collections.Generic;
using System.IO;

namespace RECURSION
{
    class Program
    {
        ////ĐỌC FOLDERS 1

        //static void Main(string[] args)
        //{
        //    string DuongDan = @"C:\Users\ASUS\Downloads\folder1";
        //    Console.WriteLine("Dung ham de quy:");
        //    List<string> TimFolder = new List<string>();
        //    DeQuy(DuongDan, TimFolder);
        //    foreach (var item in TimFolder)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}
        //static void DeQuy(string ThuMuc, List<string> DanhsachFolder)
        //{
        //    try
        //    {                                   // các lệnh có thể gây ra ngoại lệ
        //        DanhsachFolder.Add(ThuMuc);     // thêm file ThuMuc vào trong DanhsachFolder    
        //        string[] MucNhap = Directory.GetDirectories(ThuMuc);    //GetDirectories: trả về một array các folder con của một folder    
        //        foreach (string item in MucNhap)
        //        {
        //            DeQuy(item, DanhsachFolder);
        //        }
        //    }
        //    catch (System.Exception ex)              // phần code để xử lý lỗi
        //    {
        //        Console.WriteLine(ex.Message);      //Message chuỗi chứa nội dung thông báo lỗi
        //    }
        //}



        //ĐỌC FILES 2

        //static void Main(string[] args)
        //{
        //    string DuongDan = @"C:\Users\ASUS\Downloads\folder1";
        //    string[] DSFile = Directory.GetFiles(DuongDan, "*", SearchOption.AllDirectories);
        //    Console.WriteLine("Dung ham de quy:");
        //    Console.WriteLine("So luong file: " + DSFile.Length);
        //    foreach (var item in DSFile)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //static void DeQuy(string ThuMuc, ref int DemFile)
        //{
        //    string[] MucNhap = Directory.GetDirectories(ThuMuc);
        //    foreach (string item in MucNhap)
        //    {
        //        DeQuy(item, ref DemFile);
        //    }
        //    string[] NhapFile = Directory.GetFiles(ThuMuc);
        //    foreach (string TenFile in NhapFile)
        //    {
        //        DemFile++;
        //        Console.WriteLine(TenFile);
        //    }
        //}




        ////ĐỌC FILES 4
        //static void Main(string[] args)
        //{
        //    string DuongDan = @"C:\Users\ASUS\Downloads\folder1";

        //    Console.WriteLine("Dung ham de quy:");
        //    List<string> TimFolder = new List<string>();
        //    DeQuy(DuongDan, TimFolder);
        //    foreach (var item in TimFolder)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}
        //static void DeQuy(string ThuMuc, List<string> DanhsachFolder)
        //{
        //    try
        //    {                                   // các lệnh có thể gây ra ngoại lệ
        //        DanhsachFolder.Add(ThuMuc);     // thêm file ThuMuc vào trong DanhsachFolder    
        //        string[] MucNhap = Directory.GetDirectories(ThuMuc);    //GetDirectories: trả về một array các folder con của một folder    
        //        foreach (string item in MucNhap)
        //        {
        //            DeQuy(item, DanhsachFolder);
        //        }

        //    }
        //    catch (System.Exception ex)              // phần code để xử lý lỗi
        //    {
        //        Console.WriteLine(ex.Message);      //Message chuỗi chứa nội dung thông báo lỗi
        //    }
        //}


        //5
        static void Main(string[] args)
        {
            string DuongDan = @"C:\Users\ASUS\Downloads\folder1";

            Console.WriteLine("Dung de quy de tim ");
            DeQuy(DuongDan);
            Console.ReadLine();
        }
        static void DeQuy(string ThuMuc)
        {
            try
            {
                Console.WriteLine(ThuMuc);
                string[] MucNhap1 = Directory.GetDirectories(ThuMuc);
                //foreach (string item in MucNhap1)
                //{
                //    DeQuy(item);
                //}

                string[] NhapFile = Directory.GetFiles(ThuMuc);
                foreach (string item in NhapFile)
                    Console.WriteLine(item);


                string[] MucNhap2 = Directory.GetDirectories(ThuMuc);
                foreach (string item in MucNhap2)
                    DeQuy(item);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
