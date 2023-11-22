using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_Interface
{
    internal class Documents : IStorable
    {
        //field
        bool status = false;
        //properties
        public bool Status
        {
            get => status;
            set => status = value;
        }
        //constructor
        public Documents() { }
        public Documents(bool status)
        {
            this.status = status;
        }
        //Method
        public List<string> Read(ref string err, string path)
        {
            List<string> list = new List<string>();
            try
            {
                //code chinh
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = string.Empty;
                        while ((line = sr.ReadLine()) != null)
                        {
                            list.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                //Thuc hien viec ma luon phai lam
            }
            return list;
        }

        public void Write(string path, string contents)
        {
            throw new NotImplementedException();
        }
    }
}
