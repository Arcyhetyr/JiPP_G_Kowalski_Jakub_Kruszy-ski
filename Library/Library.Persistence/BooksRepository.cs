using System;
using System.Collections.Generic;
using Library.Domain;
using Library.Persistence;
using System.Linq;

namespace Library.Persistence
{
    public class BooksRepository
    {

        public readonly List<Book> _database;
        public BooksRepository()

        {
            _database = new List<Book>
        {
         new Book("Stary człowiek i morze", "Ernest Hemingway", 1986, "AAAA", 10, 19.99m, 1),
         new Book("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m, 2),
         new Book("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m, 3),
         new Book("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m, 4),
         new Book("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m, 5),
         new Book("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m, 6),
         new Book("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m, 7),
         new Book("To", "Stephen King", 2003, "HHHH", 2, 12.99m, 8),
         new Book("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m, 9),
         new Book("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m, 10),
        };
        }
            public void Insert(Book book)
            {
                _database.Add(book);
            }
        public List<Book> GetAll()
             {
               return _database;
           }
        public void RemoveByTitle(string title)
            {
                var bookToRemove = _database.First(x => x.Title == title);
                _database.Remove(bookToRemove);
            }
        public void ChangeState(string title, int stateChange)
            {
                Book book = _database.First(x => x.Title == title);
                book.ProductsAvailable += stateChange;
            }
        public bool IsBookExist(int bookId)
        {
            return _database.Any(b => b.Id == bookId);
        }
        public int GetNumberOfBooks(int bookId)
        {
            return _database.Find(book => book.Id == bookId).ProductsAvailable;
        }
          



    }
}
