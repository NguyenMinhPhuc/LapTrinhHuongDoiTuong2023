using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS10_QuanLyThuVien.MyBooks;

namespace CS10_QuanLyThuVien.LibraryManager
{
    public class BookManager
    {
        List<Book> bookList;
        public BookManager(){
            bookList=new List<Book>();
        }

        //Method
        public void AddBooks(int index){
            Book book;
            while(true){
                Console.Write("Chon Loai sach (T/N): ");
                string option=Console.ReadLine();
                if(option.ToLower().Equals("t")){
                    book=new TextBook();
                    //Them nhap cacs thong tin sach
                }else if(option.ToLower().Equals("n")){
                    book=new Novel();
                    //Them
                }else{
                    break;
                }
            }
        }
        //PrintBooks
        //SearchBooksByTitle
        //SearchBooksByAuthor
        //SortBooks
        //WriteToFile
        //ReadFromFile
    }
}