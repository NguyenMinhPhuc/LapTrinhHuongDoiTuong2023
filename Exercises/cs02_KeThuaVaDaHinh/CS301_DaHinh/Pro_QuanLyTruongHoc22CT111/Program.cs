using Pro_QuanLyTruongHoc22CT111;

internal class Program
{
    private static void Main(string[] args)
    {
        PersonManager personManager = new PersonManager();

        personManager.NhapDanhSach();

        personManager.XuatDanhSach();

        Console.Write("Nhap Ma So can tim: ");
        string maSo = Console.ReadLine();

        Person person = personManager.SearchByID(maSo);
        if (person != null)
            person.Xuat(1);
        else
        {
            Console.WriteLine("Khong co");
        }


    }
}