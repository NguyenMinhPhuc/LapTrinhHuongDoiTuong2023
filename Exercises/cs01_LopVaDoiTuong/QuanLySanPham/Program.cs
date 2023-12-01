using Internal;
using System;
using QuanLySanPham;
public class Program
{
    private static void Main(string[] args)
    {
        QLSanPham qLSanPham = new QLSanPham();
        do
        {
            Console.WriteLine("Chon menu: ");
            int chon = menu();
            switch (chon)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        qLSanPham.AddSanPham();
                    }
                    break;
                case 2:
                    qLSanPham.PrintSanPham();
                    break;
                case 3:
                    SanPham sanPham = qLSanPham.SearchSanpham("sp01");
                    if (sanPham != null)
                    {
                        sanPham.XuatThongTinSanPham();
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay san pham");
                    }
                    break;
                case 4:

                    return;
            }
        } while (true);

    }

    private static int menu()
    {
        int chon = 0;
        Console.WriteLine("1. Nhap danh sach san pham");
        Console.WriteLine("2. In danh sach san pham");
        Console.WriteLine("3. tim kiem san pham theo ID");
        Console.WriteLine("4. thoat");
        chon = Convert.ToInt32(Console.ReadLine());
        return chon;
    }
}