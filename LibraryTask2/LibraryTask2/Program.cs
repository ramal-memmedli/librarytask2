using System;
using System.Collections.Generic;
using LibraryTask2.Models;

namespace LibraryTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("English", "AuthorA", 321);
            Book book1 = new Book("Mathemathics", "AuthorB", 123);
            Book book2 = new Book("Programming", "AuthorC", 200);
            Book book3 = new Book("Chemistry", "AuthorD", 432);
            Book book4 = new Book("C#", "AuthorE", 234);
            Book book5 = new Book("JavaScript32", "AuthorF", 756);

            Library library = new Library();

            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            Console.WriteLine("-------------------- First version of library --------------------\n");

            library.ShowBooksInLibrary();

            Console.WriteLine("------------------------------------------------------------------\n");

            Console.WriteLine("--------------------- FindAllBooksByName - he --------------------\n");

            foreach (Book item in library.FindAllBooksByName("he"))
            {
                item.ShowInfo();
            }

            Console.WriteLine("------------------------------------------------------------------\n");

            Console.WriteLine("-------------------- RemoveAllBooksByName - # --------------------\n");

            library.RemoveAllBooksByName("#");
            library.ShowBooksInLibrary();

            Console.WriteLine("------------------------------------------------------------------\n");

            Console.WriteLine("------------------------ SearchBooks - 32 ------------------------\n");

            foreach (Book item in library.SearchBooks("32"))
            {
                item.ShowInfo();
            }

            Console.WriteLine("------------------------------------------------------------------\n");

            Console.WriteLine("------------- FindAllBooksByPageCountRange - 100, 300 ------------\n");

            foreach (Book item in library.FindAllBooksByPageCountRange(100, 300))
            {
                item.ShowInfo();
            }

            Console.WriteLine("------------------------------------------------------------------\n");

            Console.WriteLine("--------------------- RemoveBookByCode - PR1 ---------------------\n");

            library.RemoveBookByCode("PR3");
            library.ShowBooksInLibrary();

            Console.WriteLine("------------------------------------------------------------------\n");
        }
    }
}
