using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS10_QuanLyThuVien.MyBooks
{
    public class Book : IComparable
    {
        //field
        int bookID;
        string title, author;
        int year;
        //properties
        public int BookID { get => bookID; set => bookID = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Year { get => year; set => year = value; }

        //Constructor
        public Book(){
            this.title=string.Empty;
            this.BookID=0;
            this.author=string.Empty;
            this.year=1900;
        }
        public Book(int bookID,string title,string author,int year){
            this.title=title;
            this.bookID=bookID;
            this.author=author;
            this.year=year;
        }
        //method
        public virtual void InputBook(){

        }
        public virtual void PrintBook(){

        }
        public override string ToString(){
            return string.format("");
        }

        public virtual void Write(StreamWrite streamWrite){

        }
        public Book SearchBookByID(int id){
            return null;
        }
        public virtual Book Read(string line){

        }
        public int CompareTo(object? obj)
        {
            if (obj != null)
            {
                return this.Title.CompareTo(((Book)obj).Title);
            }
            else
            {
                return -1;
            }
        }

    }
}