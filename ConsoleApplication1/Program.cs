using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_BookService;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("Tolstoy", "War and Peace", 1865, "St.Petersburg");
            Book b = new Book("Lermontov", "Hero of Our Time", 1840, "St.Petersburg");
            Book c = new Book("Lermontov", "Daemon", 1842, "Moscow");

            List<Book> bookList = new List<Book>();
            bookList.Add(a);
            bookList.Add(b);
            bookList.Add(c);
            BookListService.SortBooks(bookList, new AuthorsDecrease());
            foreach (Book element in bookList)
            {
                Console.WriteLine(element.ToString());
            }
            Console.WriteLine();
            List<Book> bookList3 = BookListService.GiveBooksToParameter(bookList, publishedBy:"St.Petersburg");
            foreach (Book element in bookList3)
            {
                Console.WriteLine(element.ToString());
            }

            //BinaryFileRepository bfr = new BinaryFileRepository("fileBooks");
            //bfr.SaveBooks(bookList);

            //List<Book> bookList2 = (List<Book>)bfr.LoadBooks();
            //foreach (Book element in bookList2)
            //{
            //    Console.WriteLine(element.ToString());
            //}
            //bfr.SaveBooks(bookList);
            //bookList2 = (List<Book>)bfr.LoadBooks();
            //foreach (Book element in bookList2)
            //{
            //    Console.WriteLine(element.ToString());
            //}
        }
    }
}
