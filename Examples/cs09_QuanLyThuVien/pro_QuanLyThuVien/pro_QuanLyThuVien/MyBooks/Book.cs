using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pro_QuanLyThuVien.MyBooks
{
    internal class Book : IComparable, ICloneable
    {
        //field 
        int bookID;
        string title;
        string author;
        int year;
        //properties - Ctrl + Shift + R
        public int BookID { get => bookID; set => bookID = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Year { get => year; set => year = value; }

        //constructor
        public Book()
        {
            this.bookID = 0;
            this.title = string.Empty;
            this.author = string.Empty;
            this.year = 1900;
        }
        public Book(int bookID, string title, string author, int year)
        {
            this.bookID = bookID;
            this.title = title;
            this.author = author;
            this.year = year;
        }
        //method
        //in thong tin sach
        public virtual void Input(int index)
        {
            Console.WriteLine($"Nhap sach thu {++index}: ");
            Console.Write("Nhap ID: ");
            bookID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap Title: ");
            title = Console.ReadLine();

            Console.Write("Nhap Author: ");
            author = Console.ReadLine();

            Console.Write("Nhap year: ");
            bookID = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return string.Format($"\n BookID: {bookID}\n Title: {title}\n Author: {author} \n Year: {year}");
        }

        //write to file
        public virtual void Write(StreamWriter sw)
        {
            sw.WriteLine(string.Format($"{bookID},{title},{author},{year}"));
        }
        //read from file
        public virtual Book Read(string line)
        {
            Book book = null;
            if (!string.IsNullOrEmpty(line))
            {
                string[] strings = line.Split(new char[] { ',' });
                book = new Book()
                {
                    bookID = int.Parse(strings[0]),
                    title = strings[1],
                    author = strings[2],
                    year = int.Parse(strings[3])
                };
            }
            return book;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null)
                return this.bookID.Equals(((Book)obj).BookID);
            else
                return false;
        }

        public int CompareTo(object? obj)
        {
            if (obj != null)
                return this.Title.CompareTo(((Book)obj).Title);
            else
                return -1;

        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
