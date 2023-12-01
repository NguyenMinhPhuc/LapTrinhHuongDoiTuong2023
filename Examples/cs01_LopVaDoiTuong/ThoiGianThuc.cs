using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs01_LopVaDoiTuong
{
    public class ThoiGianThuc
    {
        //Bien thanh viên
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        private int second;

        //phuong thuc truy cập
        public int GetYear()
        {
            return year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        //thuoc tinh - Properties
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //prop
        public int Month { get { return month; } set { month = value; } }
        //propfull
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int Day { get => day; set => day = value; }
        public global::System.Int32 Hour { get => hour; set => hour = value; }
        public global::System.Int32 Minute { get => minute; set => minute = value; }

        //Method
        //3.1. Phương thức không giá trị trả về (void)
        public void HienThiGiaTri(int year, int month, int day)
        {
            Console.WriteLine($"{year} {month} {day}");
        }
        //3.2. Phương thức có giá trị trả về (return)
        public int SoNgayCuaThang(int thang, int year)
        {
            int dayOfMonth = 30;
            //cach tinh ngay cua thang
            return dayOfMonth;
        }

        //4. Constructor - Hàm tạo
        //4.1 Ham tao Mac dinh -default
        public ThoiGianThuc()
        {
            this.year = 1900;
            this.month = 1;
            this.day = 1;
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
        }
        //4.2 Hàm tạo có tham số
        public ThoiGianThuc(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public ThoiGianThuc(int year, int month, int day, int hour, int minute)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        //4.3 Hàm tạo sao chép
        public ThoiGianThuc(ThoiGianThuc thoiGianThuc){
            this.year = thoiGianThuc.year;
            this.month = thoiGianThuc.month;
            this.day = thoiGianThuc.day;
            this.hour = thoiGianThuc.hour;
            this.minute = thoiGianThuc.minute;
            this.second= thoiGianThuc.second;
        }
    }


    public class ThoiGianThucTest
    {
        ThoiGianThuc thoiGianThuc = new ThoiGianThuc();
        ThoiGianThuc thoiGianThuc1= new ThoiGianThuc(thoiGianThuc);
    }
}