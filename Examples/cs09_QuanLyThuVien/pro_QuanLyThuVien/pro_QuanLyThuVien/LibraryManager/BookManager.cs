using pro_QuanLyThuVien.MyBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace pro_QuanLyThuVien.LibraryManager
{
    internal class BookManager
    {
        List<Book> books;
        int index = 0;
        public BookManager()
        {
            books = new List<Book>();
        }
        public void AddBook(ref int index)
        {
            Book book;
            while (true)
            {
                Console.Write("Chon loai sach (T/N): ");
                string option = Console.ReadLine();
                if (option.ToLower().Equals("t"))
                {
                    book = new TextBook();
                }
                else if (option.ToLower().Equals("n"))
                {
                    book = new Novel();
                }
                else
                {
                    break;
                }
                book.Input(index);
                index++;
                books.Add(book);
            }
            Console.WriteLine("Hoan thanh qua trinh nhap sach");
        }
        public void PrintBooks()
        {
            if (books != null)
            {
                foreach (var book in books)
                {
                    book.ToString();
                }
            }
            else
            {
                Console.WriteLine("Khong co sach trong thu vien");
            }
        }

        public void PrintBooks(List<Book> books)
        {
            if (books != null)
            {
                foreach (var book in books)
                {
                    book.ToString();
                }
            }
            else
            {
                Console.WriteLine("Khong co sach trong thu vien");
            }
        }
        public void SearchByAuthor(string author)
        {
            List<Book> searchlist = null;
            if (books != null)
            {
                foreach (var book in books)
                {
                    searchlist = new List<Book>();
                    if (book.Author.ToLower().Equals(author.ToLower()))
                    {
                        searchlist.Add(book);
                    }
                }
                //in sach
                PrintBooks(searchlist);
            }
            else
            {
                Console.WriteLine("khong co sach can tim");
            }
        }

        public void Search(bool isAuthor)
        {
            List<Book> searchlist = null;
            string value = string.Empty;
            if (books != null)
            {
                if (isAuthor)
                {
                    Console.Write("Nhap Author can tim: ");
                    value = Console.ReadLine();
                    foreach (var book in books)
                    {
                        searchlist = new List<Book>();
                        if (book.Author.ToLower().Equals(value.ToLower()))
                        {
                            searchlist.Add(book);
                        }
                    }
                }
                else
                {
                    Console.Write("Nhap Title can tim: ");
                    value = Console.ReadLine();
                    foreach (var book in books)
                    {
                        searchlist = new List<Book>();
                        if (book.Title.ToLower().Equals(value.ToLower()))
                        {
                            searchlist.Add(book);
                        }
                    }
                }

                //in sach
                PrintBooks(searchlist);
            }
            else
            {
                Console.WriteLine("khong co sach can tim");
            }
        }

        public void SortTitle(bool asc)
        {
            if (asc)
                books.Sort();
            else
            {
                books.Sort();
                books.Reverse();
            }
        }

        public void Write(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var book in books)
                    {
                        book.Write(sw);
                    }
                }
            }
        }

        public void Read(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    Book book;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] strings = line.Split(',');
                            if (strings[4].ToLower().Equals("textbook"))
                            {
                                book = new TextBook()
                                {
                                    BookID = Convert.ToInt32(strings[0]),
                                    Title = strings[1],
                                    Author = strings[2],
                                    Year = Convert.ToInt32(strings[3]),
                                    Subject = strings[4]
                                };
                            }
                            else
                            {

                                book = new Novel();
                                book.Read(line);
                            }
                            books.Add(book);
                        }
                        DateTime.Now  }
                }
            }
        }

    }
}
