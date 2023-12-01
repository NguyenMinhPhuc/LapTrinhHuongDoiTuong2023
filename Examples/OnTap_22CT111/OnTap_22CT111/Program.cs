internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh bai thi");
        while (true)
        {
            int chon = 0;
            chon = Menu();
            switch (chon)
            {
                case 1:
                    Console.WriteLine("Chuc nang 1");
                    break;
                case 2:
                    Console.WriteLine("Chuc nang 1");
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Chuc nang 1");
                    break;
                case 5:
                    Console.WriteLine("Chuc nang 1");
                    break;
                case 6:
                    Console.WriteLine("Thoat");
                    return;
            }
        }
    }

    private static int Menu()
    {
        int chon = 0;
        Console.Write("Chon chuc nang:");
        Console.WriteLine("1.Chuc nang 1");
        Console.WriteLine("2.Chuc nang 2");
        Console.WriteLine("3.Chuc nang 3");
        Console.WriteLine("4.Chuc nang 4");
        Console.WriteLine("5.Chuc nang 5");
        Console.WriteLine("6.Thoat");
        chon = Convert.ToInt32(Console.ReadLine());
        return chon;
    }
}