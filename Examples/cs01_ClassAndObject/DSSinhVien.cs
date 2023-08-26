using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs01_ClassAndObject
{
    public class DSSinhVien
    {
        List<SinhVien> list = new List<SinhVien>();

        public void NhapDanhSachSinhVien(int count, string name)
        {
            SinhVien sinhVien = new SinhVien();
            list.Add(sinhVien);
            count++;
        }

        public int NhapDanhSachSinhVien( string na,int count)
        {
            int count = 0;
            SinhVien sinhVien = new SinhVien();
            list.Add(sinhVien);
            count++;
            return count;
        }
    }
}