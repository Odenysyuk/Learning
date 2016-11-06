using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Date_model;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = "War and peace";
                book.Author = "Lev Tolstoj";
                context.Books.Add(book);
                context.SaveChanges();
            } 
        }
    }
}
