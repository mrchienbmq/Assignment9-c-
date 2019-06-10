using System;

namespace T1807M1.Assignment8
{
    public class KHVN : KhachHang
    {
        public int LoaiKh;
        public int DinhMuc;

        public KHVN(int loaiKh, int dinhMuc)
        {
            this.LoaiKh = 0;
            this.DinhMuc = 0;
        }

        public KHVN(int khid, string tenKh, string ngayHd, int soLuong, double donGia, double thanhTien, int loaiKh, int dinhMuc) : base(khid, tenKh, ngayHd, soLuong, donGia, thanhTien)
        {
            this.Khid = 0;
            this.Tenkh = "";
            this.Ngayhd = "";
            this.Soluong = 0;
            this.Dongia = 0;
            this.Thanhtien = 0;
            this.LoaiKh = 0;
            this.DinhMuc = 0;

        }

        public KHVN()
        {
           
        }
        

        public override void Nhap()
        {
            
            Console.WriteLine("Loai Khach Hang");
            Console.WriteLine("1 Sinh Hoat");
            Console.WriteLine("2 Kinh Doanh");
            LoaiKh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dinh Muc");
            DinhMuc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Thong Tin Khach Hang");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nhap Ma Khach Hang");
            Khid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Ten Khach Hang");
            Tenkh = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhay Tao Hoa Don");
            Ngayhd = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap Vao So Luong Hang");
            Soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Vao Don Gia ");
            Dongia = Convert.ToDouble(Console.ReadLine());
        }

        public double TTien()
        {
            if (Soluong<DinhMuc)
            {
                return this.Thanhtien = this.Soluong * this.Dongia;
            }
            else
            {
                return this.Thanhtien = this.Dongia * this.DinhMuc + (this.Soluong + this.DinhMuc) * this.Dongia * 2.5;
            }
        }

        public override string ToString()
        {
            string Show = "";
            if (LoaiKh == 1)
            {
                Show = "Dan Cu";
            }
            else if (LoaiKh == 2)
            {
                Show = "Kinh Doanh";
            }
            else
            {
                Console.WriteLine("San Xuat");
            }

            return "-------------------------------" +
                   "---------Khach Hang VIET-------" +
                   "--------------------------------" +

                   "\n Ma Khach Hang : " + Khid +
                   "\n Ten Khach Hang : " + Tenkh +
                   "\n Ngay Tao Hoa Don : " + Ngayhd +
                   "\n So Luong Hang : " + Soluong +
                   "\n Don Gia : " + Dongia +
                   "\n Loai Khach Hang :" + Show +
                   "\n Dinh Muc : " + DinhMuc +
                   "\n Thanh Tien : " + Thanhtien;

        }
    }
}