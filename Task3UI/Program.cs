using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_BookService;

namespace Task3UI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Book a = new Book("Tolstoy", "War and Peace", 1865, "St.Petersburg");
            Book b = new Book("Lermontov", "Hero of Our Time", 1840, "St.Petersburg");
            Book c = new Book("Lermontov", "Daemon", 1842, "Moscow");
            Book d = new Book("Tolstoy", "War and Peace", 1865, "St.Petersburg");

            List<Book> bookList;
            BinaryFileRepository bookRepository = new BinaryFileRepository("fileBooks");
            BookListService bookService = new BookListService(bookRepository);

            //bookService.AddBook(a);
            //bookService.AddBook(b);
            //bookService.AddBook(c);
            try
            {
                bookService.AddBook(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            bookList = bookService.GetBookList();
            foreach (Book element in bookList)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine();
            bookService.SortBooks(new YearIncrease());
            bookList = bookService.GetBookList();
            foreach (Book element in bookList)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine();
            List<Book> bookList2 = bookService.GiveBooksToParameter(publishedBy: "St.Petersburg");
            foreach (Book element in bookList2)
            {
                Console.WriteLine(element.ToString());
            }

            
        }
    }
}
