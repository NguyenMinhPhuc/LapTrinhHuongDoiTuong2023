internal class Program
{
    //Khai báo biến
    //Biến khi sử dụng phải được khai báo
    //trong C# có thể khai báo biến ở bất kỳ đâu khi sử dụng
    //biến muốn sử dụng phải được gán giá trị
    static string mSSV =string.Empty;
    static string hoTenSV=string.Empty;
    static int tuoi=0;
    static DateTime ngaySinh;
    static string diaChi =string.Empty;
    static string soDienThoai=string.Empty;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Gán giá trị cho biên
        mSSV="122000123";
        hoTenSV="Nguyễn Minh Phúc";
        diaChi="Đồng Nai";
        soDienThoai="0911132826";
        ngaySinh=new DateTime(1985, 3, 21);
        Console.WriteLine($"Thông tin sinh viên gồm MSSV: {mSSV} \n- Họ và tên: {hoTenSV} \n- Tuổi : {Math.Round(DateTime.Now.Subtract(ngaySinh).TotalDays/365,0)} \n- Ngay sinh: {ngaySinh} \n- Địa chỉ: {diaChi}\n- Điện thoại: {soDienThoai}");
    }
}