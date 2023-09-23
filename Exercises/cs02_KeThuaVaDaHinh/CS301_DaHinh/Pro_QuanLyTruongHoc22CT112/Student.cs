using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    public class Student : Person
    {
        string lop, nganh;
        double diemTB, diemRenLuyen;

        public string Lop { get => lop; set => lop = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
        public double DiemRenLuyen { get => diemRenLuyen; set => diemRenLuyen = value; }

        public Student() : base()
        {
            this.lop = string.Empty;
            this.nganh = string.Empty;
            diemRenLuyen = 0;
            diemTB = 0;
        }

        public override void Nhap(int index)
        {
            base.Nhap(index);
            Console.WriteLine("Nhap them TT Sinh vien");
            Console.Write("Lop: ");
            lop = Console.ReadLine();

            Console.Write("Nganh: ");
            nganh = Console.ReadLine();

            Console.Write("Diem TB: ");
            diemTB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Diem ren luyen: ");
            diemRenLuyen = Convert.ToDouble(Console.ReadLine());
        }

        public string XepLoai(){
            string result=string.Empty;
            if(diemTB>=9){
                result="Xuat sac";
            }else if(diemTB>=8){
                result="Gioi";
            }else if(diemTB>=7){
                result="Kha";
            }else if(diemTB>=6){
                result="TB kha";
            }else if(diemTB>=5){
                result="Trung binh";
            }else{
                result="Yeu";
            }
            return result;
        }
    }
}