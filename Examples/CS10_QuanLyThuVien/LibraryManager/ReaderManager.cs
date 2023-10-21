using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS10_QuanLyThuVien.MyReaders;

namespace CS10_QuanLyThuVien.LibraryManager
{
    public class ReaderManager
    {
        List<Reader> readerList;
        public List<Reader> ReaderList { get => readerList; set => readerList = value; }
        public ReaderManager(){
            readerList=new List<Reader>();
        }
        //AddReaders(int index)
        //PrintReaders()
        //SearchReaderByID(int id)
        //SortReaders()
        //Write()
        //Read()



    }
}