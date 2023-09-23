using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT112
{
    internal class FileTxt : ILoaiFile
    {
        public List<Person> Read(string path)
        {
            List<Person> list = new List<Person>();
            try
            {
                Person person;
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {

                        string? line = string.Empty;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] strings = line.Split(',');
                                if (strings[0].ToLower().Equals("t"))
                                {
                                    person = new Teacher()
                                    {
                                        MaSo = strings[1],
                                        Ho = strings[2],
                                        Ten = strings[3],
                                        NgaySinh = Convert.ToDateTime(strings[4]),
                                        GioiTinh = Convert.ToBoolean(strings[5]),
                                        DiaChi = strings[6],
                                        SoDienThoai = strings[7],
                                        HocHam = strings[8],
                                        HocVi = strings[9],
                                        SoTietDay = Convert.ToInt32(strings[10])
                                    };


                                }
                                else
                                {
                                    person = new Student()
                                    {
                                        MaSo = strings[1],

                                        Ho = strings[2],
                                        Ten = strings[3],
                                        NgaySinh = Convert.ToDateTime(strings[4]),
                                        GioiTinh = Convert.ToBoolean(strings[5]),
                                        DiaChi = strings[6],
                                        SoDienThoai = strings[7],
                                        Lop = strings[8],
                                        Nganh = strings[9],
                                        DiemTB = Convert.ToDouble(strings[10]),
                                        DiemRenLuyen = Convert.ToDouble(strings[11])
                                    };
                                }
                                list.Add(person);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public void Write(string path, List<Person> people)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        foreach (Person person in people)
                        {
                            streamWriter.WriteLine(person.ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
