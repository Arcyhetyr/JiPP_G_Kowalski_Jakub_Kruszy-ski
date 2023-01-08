using System;
using Library.Domain;
using Library.Persistence;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Library.ConsoleApp
{
    class BooksService
    {

        private readonly BooksRepository _repository;
        public BooksService(BooksRepository repository)
        {
            _repository = repository;
        }
       
        
        public void AddBook()
        {
            Console.WriteLine("Enter Book ID(currently we have 10 books ID in stock)");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter book author:");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book publication year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter book ISBN:");
            string isbn = Console.ReadLine();
            Console.WriteLine("Enter book stock:");
            int stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter book price:");
            decimal price = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);
            
          // decimal price = decimal.Parse("1200.00", CultureInfo.InvariantCulture);

            Book BookToAdd = new Book(title, author, year, isbn, stock, price, id);
            _repository.Insert(BookToAdd);
            //tu bedzie dodawanie
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter book title to remove:");
            string title = Console.ReadLine();
            _repository.RemoveByTitle(title);
            //tutaj bedzie usuwanie


        }

        public void ListBooks()
        {
            Console.WriteLine("Here is the list of books:");
            List<Book> books = _repository.GetAll();
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }
            //tu bedzie  listowanie

        }
        public void ChangeState()
        {
            Console.WriteLine("Enter book title to change stock:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter changed stcok: ");
            int stateChange = Convert.ToInt32(Console.ReadLine());
            _repository.ChangeState(title, stateChange);
            //tu bedzie zmiana
        }
        
    }
}