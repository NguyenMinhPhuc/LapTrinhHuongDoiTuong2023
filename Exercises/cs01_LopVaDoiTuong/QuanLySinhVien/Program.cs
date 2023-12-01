namespace QuanLySinhVien
{
    internal class Program
    {
        public static void nhap(){

        }
        private static void Main(string[] args)
        {
            //Khai báo
            nhap();
            SinhVien sinhVien;

           string a= Cls_Main.Path;
            //Khởi tạo

            Cls_Main.DocThongTinHeThong();
            sinhVien = new SinhVien();

            SinhVien sinhVien1 = new SinhVien();
            sinhVien1.MSSV = "122000123";
            sinhVien1.HoVaTen = "Nguyễn Minh Phúc";

            SinhVien sinhVien2 = new SinhVien(){
                MSSV = "122000123",
                HoVaTen="Nguyễn Minh Hoang",
                GioiTinh=true;
            };

            SinhVien sinhVien3 = new SinhVien();
            sinhVien3=NhapSinhVien();

        }
    }

}