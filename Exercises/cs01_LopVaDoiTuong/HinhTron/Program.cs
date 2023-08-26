using HinhTron.Sharp;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Vuong vuong = new Vuong();
        Tron tron = new Tron(2);
        Console.WriteLine($"Chu vi hinh tron {tron.ChuVi()}");
        Console.WriteLine($"Dien tich hinh tron {tron.DienTich()}");


    }
}