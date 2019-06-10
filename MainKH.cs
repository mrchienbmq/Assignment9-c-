using System;

namespace T1807M1.Assignment8
{
    public class MainKH
    {
        public static void Main(string[] args)
        {
            KhachHangList khl = new KhachHangList(); 
            int x ;


            do
            {
                while (true)
                {
                    Console.WriteLine("-------------------QUAN LY KHACH HANG--------------------");
                    Console.WriteLine("1. THEM KHACH HANG VIET NAM");
                    Console.WriteLine("2. THEM KHACH HANG NUOC NGOAI");
                    Console.WriteLine("3. HIEN THI DANH SACH KHACH HANG");
                    Console.WriteLine("4. XEM TONG KW DIEN CUA KHACH HANG");
                    Console.WriteLine("5. XEM TRUNG BINH THANH TIEN CUA KHACH HANG NUOC NGOAI");
                    Console.WriteLine("6 THOAT UNG DUNG");
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Nhap vao lua chon");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            khl.ThemKh(1);
                            break;
                        case 2:
                            khl.ThemKh(2);
                            break;
                        case 3:
                            khl.HienthiKh();
                            break;
                        case 4:
                            khl.TongSoLuong();
                            break;
                        case 5:
                            khl.TrungBinh();
                            break;
                        case 6:
                            Console.WriteLine("Thoat Ung Dung");
                            break;
                    
                    }
                }
               
                
            } while (x == 6);

        }
     }
  }

