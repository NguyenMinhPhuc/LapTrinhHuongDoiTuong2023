using OnTap;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh bai thi");
        QuanLySanPham quanLySanPham = new QuanLySanPham();
        int chon = 0;

        while (true)
        {
            chon = Menu();
            switch (chon)
            {
                case 1:
                    Console.WriteLine("Chuc nang 1");
                    int maSP;
                    break;
                case 2:
                    Console.WriteLine("Chuc nang 1");
                    maSP = 9;
                    break;
                case 3:
                    Console.WriteLine("Chuc nang 1");
                    break;
                case 4:
                    Console.WriteLine("Chuc nang 1");
                    break;
                case 5:
                    Console.WriteLine("Chuc nang 1");
                    break;
                case 6:
                    return;
            }
        }
    }

    private static int Menu()
    {
        int chon = 0;
        Console.WriteLine("1. Chuc nang 1");
        Console.WriteLine("2. Chuc nang 2");
        Console.WriteLine("3. Chuc nang 3");
        Console.WriteLine("4. Chuc nang 4");
        Console.WriteLine("5. Chuc nang 5");
        Console.WriteLine("6. Thoat");
        Console.Write("Nhap Chuc nang: ");
        chon = Convert.ToInt32(Console.ReadLine());
        return chon;
    }

}