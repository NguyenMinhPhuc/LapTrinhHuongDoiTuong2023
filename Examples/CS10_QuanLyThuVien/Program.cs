internal class Program
{
    private static void Main(string[] args)
    {
        
        while(true){
            int option;
            option=Menu();
            switch (option)
            {
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                break;
                case 6:
                break;
                case 7:
                break;
                default:
                return;


            }
        }
    }

    static int Menu()
    {
        int option;
        Console.WriteLine("\n1.Them sach vao thu vien");
        Console.WriteLine("2.In danh sach sach thu vien");
        Console.WriteLine("3.Tim kiem sach theo tac gia");
        Console.WriteLine("4.Tim kiem sach theo ten sach");
        Console.WriteLine("5.Sap xep sachs theo ten sach");
        Console.WriteLine("6.Muon sach");
        Console.WriteLine("7.Tra sach");
        Console.WriteLine("8.Thoat");
        Console.Write("Chon chuc nang: ");
        option=Convert.ToInt32(Console.ReadLine());
        return option;

    }
}