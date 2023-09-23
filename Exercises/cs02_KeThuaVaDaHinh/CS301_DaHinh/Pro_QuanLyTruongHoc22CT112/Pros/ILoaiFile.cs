using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    internal interface ILoaiFile
    {
        List<Person> Read(string path);
        void Write(string path, List<Person> people);

    }
}
