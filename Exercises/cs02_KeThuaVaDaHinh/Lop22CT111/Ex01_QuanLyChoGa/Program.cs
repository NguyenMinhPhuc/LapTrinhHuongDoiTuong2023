using EX01_QuanLyChoGa;
internal class Program
{
    private static void Main(string[] args)
    {
       DongVat dongVat=new Cho();
       dongVat.Nhap();
       dongVat.Xuat();

       dongVat=new Ga();
       dongVat.Nhap();
       dongVat.Xuat();

    }
}