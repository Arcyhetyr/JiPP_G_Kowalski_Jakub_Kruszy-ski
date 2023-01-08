using System;

namespace Library.Domain
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public int ProductsAvailable { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }

        public Book() { }

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price, int id)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
            Id = id;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }
    }
}

