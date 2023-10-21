using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS10_QuanLyThuVien.LibraryManager
{
    public class BorrowAndReturn
    {
        Book borrowBook;
        Reader borrowReader;
        DateTime borrowDate;
        DateTime returnDate;
        long fine;
        bool returnStatus;

        public Book BorrowBook { get => borrowBook; set => borrowBook = value; }
        public Reader BorrowReader { get => borrowReader; set => borrowReader = value; }
        public DateTime BorrowDate { get => borrowDate; set => borrowDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public global::System.Int64 Fine { get => fine; set => fine = value; }
        public global::System.Boolean ReturnStatus { get => returnStatus; set => returnStatus = value; }



        //add
        //print
        //Tinh Tien phat
        //write
        //read

    }
}