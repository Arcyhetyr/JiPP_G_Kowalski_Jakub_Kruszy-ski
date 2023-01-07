using System;
using System.Collections.Generic;
using System.Text;


namespace Library.Domain
{
   public class BookOrdered
    {
        public int BookId { get; set; }
        public int NumberOrdered { get; set; }
        public BookOrdered(int bookId, int numberOrdered)
        {
            BookId = bookId;
            NumberOrdered = numberOrdered;
        }
    }
}
