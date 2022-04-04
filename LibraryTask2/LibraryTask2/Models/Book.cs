using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask2.Models
{
    public class Book
    {
        private static int _id;
        private int _pageCount;

        public int Id { get; private set; }

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get { return _pageCount; } set { if (value > 0) _pageCount = value; } }
        public string Code { get; set; }

        static Book()
        {
            _id = 0;
        }

        private Book()
        {
            Id = ++_id;
        }

        public Book(string name, string authorName, int pageCount) : this()
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = Name[0].ToString().ToUpper() + Name[1].ToString().ToUpper() + Id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Author name: {AuthorName}, Page count: {PageCount}, Code: {Code}\n");
        }
    }
}
