using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pro_QuanLyThuVien.MyBooks
{
    internal class TextBook : Book
    {
        string subject;

        public string Subject { get => subject; set => subject = value; }
        public TextBook() : base()
        {
            this.subject = string.Empty;
        }
        public TextBook(string subject, int bookID, string title, string author, int year) : base(bookID, title, author, year)
        {
            this.subject = subject;
        }
        public override void Input(int index)
        {
            base.Input(index);
            Console.Write("Nhap subject: ");
            subject = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSubject: {subject}";
        }
        public override void Write(StreamWriter sw)
        {
            base.Write(sw);
            sw.WriteLine(",textbook," + subject);
        }
        public override Book Read(string line)
        {
            Book book = new TextBook();
            book = base.Read(line);
            string[] strings = line.Split(',');
            ((TextBook)book).Subject = strings[4];
            return book;
        }
    }
}
