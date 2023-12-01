using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_QuanLyTruongHoc22CT111.Pros
{
    internal class FileBat : IFileType
    {
        public List<Person> Read(string path)
        {
            List<Person> listRead = new List<Person>();
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (BinaryReader reader = new BinaryReader(fileStream))
                {
                    Person person = null;
                    while (reader.PeekChar() != -1)
                    {
                        string text = reader.ReadString();
                        if (text.ToLower().Equals(text))
                        {
                            person = new Teacher()
                            {
                                MaSo = reader.ReadString(),
                                Ho = reader.ReadString(),
                                Ten = reader.ReadString(),
                                NgaySinh = Convert.ToDateTime(reader.ReadString()),
                                GioiTinh = reader.ReadBoolean(),
                                DiaChi = reader.ReadString(),
                                SoDienThoai = reader.ReadString(),
                                HocHam = reader.ReadString(),
                                HocVi = reader.ReadString(),
                                SoTietDay = reader.ReadInt32()
                            };
                        }
                        else
                        {
                            person = new Student()
                            {
                                MaSo = reader.ReadString(),
                                Ho = reader.ReadString(),
                                Ten = reader.ReadString(),
                                NgaySinh = Convert.ToDateTime(reader.ReadString()),
                                GioiTinh = reader.ReadBoolean(),
                                DiaChi = reader.ReadString(),
                                SoDienThoai = reader.ReadString(),
                                Lop = reader.ReadString(),
                                Nganh = reader.ReadString(),
                                DiemTB = reader.ReadDouble(),
                                DiemRL = reader.ReadDouble()
                            };
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
                using (BinaryWriter writer = new BinaryWriter(fileStream))
                {
                    foreach (Person person in people)
                    {

                        if (person is Teacher)
                        {
                            writer.Write("T");
                            writer.Write(person.MaSo);
                            writer.Write(person.Ho);
                            writer.Write(person.Ten);
                            writer.Write(person.NgaySinh.ToString());
                            writer.Write(person.GioiTinh);
                            writer.Write(person.DiaChi);
                            writer.Write(person.DiaChi);
                            writer.Write(((Teacher)person).HocHam);
                            writer.Write(((Teacher)person).HocVi);
                            writer.Write(((Teacher)person).SoTietDay);
                        }
                        else
                        {
                            writer.Write("S");
                            writer.Write(person.MaSo);
                            writer.Write(person.Ho);
                            writer.Write(person.Ten);
                            writer.Write(person.NgaySinh.ToString());
                            writer.Write(person.GioiTinh);
                            writer.Write(person.DiaChi);
                            writer.Write(person.DiaChi);
                            writer.Write(((Student)person).Lop);
                            writer.Write(((Student)person).Nganh);
                            writer.Write(((Student)person).DiemTB);
                            writer.Write(((Student)person).DiemRL);
                        }
                    }
                }
            }
        }
    }
}
