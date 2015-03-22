using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_BookService;
using NLog;

namespace Task3UI
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Book a = new Book("Tolstoy", "War and Peace", 1865, "St.Petersburg");
            Book b = new Book("Lermontov", "Hero of Our Time", 1840, "St.Petersburg");
            Book c = new Book("Lermontov", "Daemon", 1842, "Moscow");
            Book d = new Book("Tolstoy", "War and Peace", 1865, "St.Petersburg");

            List<Book> bookList = new List<Book>();
            bookList.AddBook(a);
            bookList.AddBook(b);
            bookList.AddBook(c);
            try
            {
                bookList.AddBook(d);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                Console.WriteLine(e.Message);
            }

            BookListService.SortBooks(bookList, new YearIncrease());
            logger.Trace("Sorted by year:");
            foreach (Book element in bookList)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine();
            List<Book> bookList3 = BookListService.GiveBooksToParameter(bookList, publishedBy: "St.Petersburg");
            foreach (Book element in bookList3)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine();
            BinaryFileRepository bfr = new BinaryFileRepository("fileBooks");
            logger.Trace("Saving books");
            Console.WriteLine("Saving books");
            bfr.SaveBooks(bookList);

            Console.WriteLine();
            logger.Trace("Open file with books");
            Console.WriteLine("Open file with books");
            List<Book> bookList2 = (List<Book>)bfr.LoadBooks();
            foreach (Book element in bookList2)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
