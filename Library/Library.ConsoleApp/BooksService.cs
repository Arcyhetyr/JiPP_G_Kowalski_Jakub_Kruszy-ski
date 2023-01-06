using System;
using Library.Domain;
using Library.Persistence;
using System.Collections.Generic;
using System.Text;

namespace Library.ConsoleApp
{
    class BooksService
    {

        public void AddBook()
        {
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
            decimal price = Convert.ToDecimal(Console.ReadLine());


            Book booktoAdd = new Book(title, author, year, isbn, stock, price);
            //tu bedzie dodawanie
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter book title to remove:");
            string title = Console.ReadLine();
            //tutaj bedzie usuwanie


        }

        public void ListBooks()
        {
            Console.WriteLine("Here is the list of books:");
            //tu bedzie  listowanie

        }
        public void ChangeState()
        {
            Console.WriteLine("Enter book title to change stock:");
            string title = Console.ReadLine();
            Convert.ToInt32(title);
            Console.WriteLine("State of title has ben changed and it is: " + title);
            //tu bedzie zmiana
        }
        
    }
}