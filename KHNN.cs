using System;

namespace T1807M1.Assignment8
{
    public class KHNN : KhachHang
    {
        public string quoctich;

        public KHNN(string quocTich)
        {
            this.quoctich = "";
        }

        public KHNN()
        {
            
        }

        public KHNN(int khid, string tenKh, string ngayHd, int soLuong, double donGia, double thanhTien, string quocTich) : base(khid, tenKh, ngayHd, soLuong, donGia, thanhTien)
        {
            this.khid = khid;
            this.ngayhd = ngayHd;
            this.soluong = soLuong;
            this.dongia = donGia;
            this.thanhtien = thanhTien;
            this.quoctich = quocTich;
        }

        public string Quoctich
        {
            get => quoctich;
            set => quoctich = value;
        }


        public override void Nhap()
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
           Console.WriteLine("Nhap Quoc Tich: ");
           quoctich = Convert.ToString(Console.ReadLine());
           
        }

        public double TTien()
        {
            return this.Thanhtien = this.Soluong * this.Dongia;
        }

        public override string ToString()
        {
            return "--------------------------------"+
                   "  KHACH HANG NUOC NGOAI " + 
                   "---------------------------------"+
                   "\n  Ma Khach Hang : " + Khid + 
                   "\n  Ten Khach Hang : " + Tenkh + 
                   "\n  Ngay Tao Hoa Don : " + Ngayhd +
                   "\n  So Luong Hang : " + Soluong + 
                   "\n  Don Gia : " + Dongia  + 
                   "\n  Quoc Tich : " + Quoctich + 
                   "\n  Thanh Tien : " + Thanhtien;
        }
        
    }
    
}
