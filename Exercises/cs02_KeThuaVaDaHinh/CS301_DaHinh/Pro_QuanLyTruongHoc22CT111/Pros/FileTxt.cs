using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT111.Pros
{
    internal class FileTxt : IFileType
    {
        public List<Person> Read(string path)
        {
            List<Person> listRead = new List<Person>();
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                    Person person = null;
                    while ((line = reader.ReadLine()) != null)
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
                                    SoTietDay = Convert.ToDouble(strings[10])
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
                                    DiemRL = Convert.ToDouble(strings[11])
                                };
                            }
                            listRead.Add(person);
                        }
                    }
                }
            }
            return listRead;
        }

        public void Write(string path, List<Person> people)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (Person person in people)
                    {
                        writer.WriteLine(person.ToString());
                    }
                }
            }
        }
    }
}
