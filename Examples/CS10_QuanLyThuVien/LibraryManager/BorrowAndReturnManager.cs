using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS10_QuanLyThuVien.MyBooks;
using CS10_QuanLyThuVien.MyReades;

namespace CS10_QuanLyThuVien.LibraryManager
{
    public class BorrowAndReturnManager
    {
        List<BorrowAndReturn> borrowList;

        public BorrowAndReturnManager()
        {
            borrowList = new List<BorrowAndReturn>();
        }

        //Muon sach --Add
        public void BorrowBook(int bookId,int readerID){
            BorrowAndReturn br=new BorrowAndReturn(){
                BorrowReader=SearchReaderByID(readerID),BorrowBook=SearchBookByID(bookId),
                BorrowDate= DateTime.Now();
                ReturnDate=new DateTime(1900,1,1),
                Fine=0;
                ReturnStatus=false;
            };
            borrowList.Add(br);
        }



        //Tra sach --Update
        public void ReturnBook(ind bookID,int readerID){
            foreach (BorrowAndReturn item in borrowList)
            {

            }
        }

        //Print

        //Tim kiem nhung da muon

        //tim kiem sach da tra

        // tim kiem sach muon chua tra

        // tim kiem sach tre han
        //Chú ý: kiểu ngày tháng, khi trừ với nhau, == ra đơn vị Timespane.Days
    }
}