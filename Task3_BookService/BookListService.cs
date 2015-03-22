using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_BookService
{
    public static class BookListService
    {
        public static void AddBook(this List<Book> bookList, Book book)
        {
            if (bookList == null || book == null) throw new ArgumentNullException("null-parameters in AddBook");

            foreach (Book element in bookList)
            {
                if (element.Equals(book)) throw new ArgumentException("This book already exists.");
            }

            bookList.Add(book);
        }

        public static void SortBooks(List<Book> bookList, IComparer<Book> compareLogic)
        {
            if (bookList == null || compareLogic == null) throw new ArgumentNullException("null-parameters in SortBooks");
            bookList.Sort(compareLogic);
        }

        public static List<Book> GiveBooksToParameter(List<Book> bookList, String author = null, String title = null, int year = 0, String publishedBy = null)
        {
            if (bookList == null || (author == null && title == null && year == 0 && publishedBy == null))
                throw new ArgumentNullException("null-parameters in GiveBooksToParameter");
            List<Book> newBookList = new List<Book>();
            foreach (Book element in bookList)
            {
                bool parameterEquals = true;
                if (author != null)
                    if (element.Author != author) { parameterEquals = false; continue; }
                if (title != null)
                    if (element.Title != title) { parameterEquals = false; continue; }
                if (year != 0)
                    if (element.Year != year) { parameterEquals = false; continue; }
                if (publishedBy != null)
                    if (element.PublishedBy != publishedBy) { parameterEquals = false; continue; }
                if (parameterEquals) newBookList.Add(element);
            }
            if (newBookList.Count == 0) throw new ArgumentException("There are no books with such specification if the store.");
            else return newBookList;
        }

    }
}
