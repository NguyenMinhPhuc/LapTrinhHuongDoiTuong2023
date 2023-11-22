using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_NguyenTacSOLID.NguyenTac01_TheoSolid
{
    internal class SaveFile
    {
        public static int a = 8;
        public SaveFile() { }

        //content:Employee 1,NGuyen Minh Phuc
        //Content:Student: 1, nguyen thi b, 22ct111
        public static bool Save(ref string err, string path, string contents)
        {
            try
            {
                //thuc hien ghi file
                return true;
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }

        public List<string> GetFiles(ref string err, string path)
        {
            List<string> lists = new List<string>();
            try
            {
                //thuc hien doc
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return lists;
        }
    }
}
