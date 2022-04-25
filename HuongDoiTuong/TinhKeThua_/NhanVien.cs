using System;
using System.Collections.Generic;
using System.Text;

namespace TinhKeThua_
{
    class NhanVien : Nguoi
    {
        private string bangcap;
        public NhanVien(string maso, string hoten, string gioitinh, string bangcap)
            : base(maso, hoten, gioitinh)
        {
            this.bangcap = bangcap;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap thong tin bang cap: ");
            bangcap = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Bang cao: {0}", bangcap);
        }

        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien("", "", "", "");
            nv.Nhap();
            nv.HienThi();

        }
    }
}
