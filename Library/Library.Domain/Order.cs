using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
  
        public class Order
        {
            public DateTime Date { get; set; }
            public List<BookOrdered> BooksOrderedList { get; set; }

            public Order()
            {
                Date = DateTime.Now;
                BooksOrderedList = new List<BookOrdered>();
            }
        public override string ToString()
        {
            string result = $"Order: {Date.ToString()}\n";
            foreach (var book in BooksOrderedList)
            {
                result += $"Book: {book.BookId} Count: {book.NumberOrdered}\n";
            }
            return result;
        }
    }
    }

