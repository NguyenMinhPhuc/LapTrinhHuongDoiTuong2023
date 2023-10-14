using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_QuanLyThuVien.MyBooks
{
    internal class Novel : Book
    {
        string genre;

        public string Genre { get => genre; set => genre = value; }
        public Novel() : base()
        {
            this.genre = string.Empty;
        }
        public Novel(string genre, int bookID, string title, string author, int year) : base(bookID, title, author, year)
        {
            this.genre = genre;
        }
        public override void Input(int index)
        {
            base.Input(index);
            Console.Write("Nhap genre: ");
            genre = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"\n Genre: {genre}";
        }
        public override void Write(StreamWriter sw)
        {
            base.Write(sw);
            sw.WriteLine(",novel," + genre);
        }
        public override Book Read(string line)
        {
            Book book = new TextBook();
            book = base.Read(line);
            string[] strings = line.Split(',');
            ((Novel)book).genre = strings[4];
            return book;
        }
    }
}
