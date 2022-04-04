using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask2.Models
{
    public class Library
    {
        public List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            if (book == null) throw new ArgumentNullException("Input can't be null or empty");
            Books.Add(book);
        }

        public List<Book> FindAllBooksByName(string textValue)
        {
            if (string.IsNullOrEmpty(textValue) && string.IsNullOrWhiteSpace(textValue)) throw new ArgumentNullException("Input can't be null or empty");
            List<Book> outputBooks = new List<Book>();
            return outputBooks = Books.FindAll(x => x.Name.ToLower().Contains(textValue.ToLower()));
        }

        public void RemoveAllBooksByName(string textValue)
        {
            if (string.IsNullOrEmpty(textValue) && string.IsNullOrWhiteSpace(textValue)) throw new ArgumentNullException("Input can't be null or empty");
            List<Book> books = FindAllBooksByName(textValue);
            foreach (Book book in books)
            {
                Books.Remove(book);
            } 
        }

        public List<Book> SearchBooks(string textValue)
        {
            if (string.IsNullOrEmpty(textValue) && string.IsNullOrWhiteSpace(textValue)) throw new ArgumentNullException("Input can't be null or empty");
            List<Book> outputBooks = new List<Book>();
            List<Book> resultList = new List<Book>();
            outputBooks = FindAllBooksByName(textValue);
            outputBooks.AddRange(Books.FindAll(x => x.AuthorName.ToLower().Contains(textValue.ToLower())));
            outputBooks.AddRange(Books.FindAll(x => x.PageCount.ToString().Contains(textValue)));
            return resultList = outputBooks.Distinct<Book>().ToList<Book>();
        }

        public List<Book> FindAllBooksByPageCountRange(int? minPageCount, int? maxPageCount)
        {
            if (minPageCount == null || maxPageCount == null) throw new ArgumentNullException("Input can't be null");
            List<Book> outputBooks = new List<Book>();
            return outputBooks = Books.FindAll(x => x.PageCount > minPageCount && x.PageCount <= maxPageCount);
        }

        public void RemoveBookByCode(string bookCode)
        {
            if(string.IsNullOrEmpty(bookCode) && string.IsNullOrWhiteSpace(bookCode)) throw new ArgumentNullException("Input can't be null or empty");
            int indexForRemove = Books.IndexOf(Books.Find(x => x.Code == bookCode.ToUpper()));
            Books.RemoveAt(indexForRemove);
        }

        public void ShowBooksInLibrary()
        {
            foreach (Book book in Books)
            {
                book.ShowInfo();
            }
        }
    }
}
