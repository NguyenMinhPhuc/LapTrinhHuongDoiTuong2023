using Pro_QuanLyTruongHoc22CT112;


internal class Program
{
    private static void Main(string[] args)
    {
        SchoolManager schoolManager = new SchoolManager();
        schoolManager.NhapDanhSach();

        schoolManager.XuatDanhSach();

        string maSo;
        Console.Write("Nhap maSo can sua: ");
        maSo = Console.ReadLine();
        schoolManager.Update(maSo);

        FactoryLoaiFile factoryLoaiFile = new FactoryLoaiFile();
        factoryLoaiFile.CreateLoaiFile(ELoaiFile.TXT);
        //factoryLoaiFile.LoaiFile.Read("");


        string path = "";
    }
}