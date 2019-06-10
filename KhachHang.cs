using System;

namespace T1807M1.Assignment8
{
    public class KhachHang
    {
        public int khid;
        public string tenkh;
        public string ngayhd;
        public int soluong;
        public double dongia;
        public double thanhtien;


        public KhachHang()
        {

        }


        /*
        public int Khid{
            get{ return khid ;}
            set{ khid = value;}
        }

        public string TenKh{
            get{ return tenkh;}
            set{ tenkh = value;}
        }

        public string NgayHd{
            get{ return ngayhd;}
            set{ ngayhd = value;}
        }

        public int SoLuong{
            get{ return soluong;}
            set{ soluong = value;}
        }

        public double DonGia{
            get{ return dongia;}
            set{ dongia = value;}
        }

        public double ThanhTien{
            get{ return thanhtien;}
            set{ thanhtien = value;}
        }
        */

        public int Khid
        {
            get;
            set ;
        }

        public string Tenkh
        {
            get;
            set;
        }

        public string Ngayhd
        {
            get;
            set;
        }

        public int Soluong
        {
            get;
            set;
        }

        public double Dongia
        {
            get;
            set;
        }

        public double Thanhtien
        {
            get;
            set;
        }


        public KhachHang(int khid, string tenkh, string ngayhd, int soluong, double dongia, double thanhtien)
        {
            this.Khid = khid;
            this.Tenkh = tenkh;
            this.Ngayhd = ngayhd;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien;
        }


        public virtual void Nhap()
        {
            Console.WriteLine("Nhap Thong Tin Khach Hang");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nhap Ma Khach Hang");
            Khid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Ten Khach Hang");
            Tenkh = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap Tao Hoa Don");
            Ngayhd = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap Vao So Luong Hang");
            Soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Vao Don Gia ");
            Dongia = Convert.ToDouble(Console.ReadLine());
            
        }

        public override string ToString()
        {
            return "\n Ma Khach Hang" + Khid + 
                   "\n Ten Khach Hang" + Tenkh + 
                   "\n Ngay Tao Hoa Don" + Ngayhd + 
                   "\n So Luong Hang" + Soluong + 
                   "\n Don Gia" + Dongia;
            
        }
    }
}