using Pro_QuanLyTruongHoc22CT111;
using Pro_QuanLyTruongHoc22CT111.Factory;
using Pro_QuanLyTruongHoc22CT111.Pros;

internal class Program
{
    private static void Main(string[] args)
    {
        PersonManager personManager = new PersonManager();

        //   personManager.NhapDanhSach();

        //personManager.XuatDanhSach();

        MyFactory myFactory = new MyFactory();
        myFactory.CreateFileType(EnumLoaiFile.DAT);
        string path = @"D:\FilePerson.dat";

        personManager.List = myFactory.FileType.Read(path);
        // myFactory.FileType.Write(path, personManager.List);
        personManager.XuatDanhSach();

    }
}