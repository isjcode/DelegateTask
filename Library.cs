using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    public class Library
    {
        public List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> books = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Contains(name))
                {
                    books.Add(book);
                }
            }

            return books;
        }

        public void RemoveAllBooksByName(string name)
        {
            foreach (Book book in Books.ToList())
            {
                if (book.Name.Contains(name))
                {
                    Books.Remove(book);
                }
            }
        }

        public List<Book> SearchBooks(string name)
        {
            List<Book> ret = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Contains(name) || book.AuthorName.Contains(name) ||
                    book.PageCount.ToString().Contains(name) || book.Code.Contains(name))
                {
                    ret.Add(book);
                }
            }

            return ret;
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> ret = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.PageCount > min && book.PageCount < max)
                {
                    ret.Add(book);
                }
            }

            return ret;
        }

        public void RemoveByNo(string code)
        {
            foreach (Book book in Books.ToList())
            {
                if (book.Code == code)
                {
                    Books.Remove(book);
                }
            }
        }
    }
}
        