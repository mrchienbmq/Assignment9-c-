using System;

namespace T1807M1.Assignment8
{
    public class KhachHangList : KhachHang
    {
        public KhachHang[] ArKh = new KhachHang[100];
        public int DemKh, sum1 = 0, sum2 = 0, dem = 0;
        public double Sumtien=0;

        public KhachHangList()
        {
            DemKh = 0;
            for (int i = 0; i < 100; i++)
            {
                ArKh[i] = new KhachHang();
            }
        }

        public void ThemKh(int show)
        {
            if (DemKh > 100)
            {
                Console.WriteLine("Bo Nho Da Day");
            }
            else
            {
                if (show == 1)
                {
                    ArKh[DemKh] = new KHVN();
                    KHVN khvn = new KHVN();
                    khvn.Nhap();
                    ArKh[DemKh] = khvn;
                    khvn.Thanhtien = khvn.TTien();
                    sum1 += khvn.Soluong;
                    

                }
                else
                {
                    ArKh[DemKh] = new KHNN();
                    KHNN khachhangNn = new KHNN();
                    khachhangNn.Nhap();
                    khachhangNn.Thanhtien = khachhangNn.TTien();
                    ArKh[DemKh] = khachhangNn;
                    sum2 += khachhangNn.Soluong;
                    Sumtien += khachhangNn.Thanhtien;
                }

                DemKh++;
            }
        }

        public void HienthiKh()
        {
            for (int i = 1; i < DemKh; i++)
            {
                Console.WriteLine("\n SO TT: "+  (+i));
                Console.WriteLine(ArKh[i].ToString());
            }
        }

        public void TongSoLuong()
        {
            Console.WriteLine("Tong So Luong (KW) Dien cua KH Viet Nam:  " +sum1);
            Console.WriteLine("Tong So Luong (KW) Dien cua KH Nuoc Ngoai:  " +sum2);
        }

        public void TrungBinh()
        {
            Console.WriteLine("---- Trung Binh Thanh Tien Cua Khach Hang Nuoc Ngoai: "+(Sumtien/DemKh));
        }
    }
    
}