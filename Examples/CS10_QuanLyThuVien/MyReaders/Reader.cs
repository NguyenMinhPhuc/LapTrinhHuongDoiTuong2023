using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS10_QuanLyThuVien.MyReaders
{
    public class Reader
    {
        int readerID;
        string name,address,phone;

        public int ReaderID { get => readerID; set => readerID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        //Constructor

        //Method
        public void InputReader(){

        }
        public void PrintReader(){

        }
        public Reader SeachReaderByID(int iD){
            return null;
        }
        public override string ToString(){
            return string.format("");
        }

    }
}