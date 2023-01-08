using System;
using Library.Domain;
using Library.Persistence;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace Library.ConsoleApp
{
    public class OrderService
    {
        private readonly OrdersRepository _orderRepository;
        


        public OrderService(OrdersRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
  
        public void PlaceOrder()
        {
            Order order = new Order();
            string command = "add";
            while (command!="end")

            {
                Console.WriteLine("add - add item to your order");
                Console.WriteLine("end - end your order");
                command = Console.ReadLine();
                if (command == "add")
                {
                    Console.WriteLine("Type book id");
                    int bookId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type amount of books");
                    int count = int.Parse(Console.ReadLine());
                    // BookOrdered bookOrdered = new BookOrdered { BookId = bookId, NumberOrdered = count };
                    // order.BooksOrderedList.Add(bookOrdered);


                    //    Console.WriteLine("Book with given ID does not exist in the repository");



                    BooksRepository bookRepository = new BooksRepository();
                    bool isBookExist = bookRepository.IsBookExist(bookId) ;
                    int GetNumberOfBooks = bookRepository.GetNumberOfBooks(bookId);
                    Console.WriteLine(isBookExist);
                    if (isBookExist == true)
                    {
                        if (GetNumberOfBooks >= count)
                        {
                            BookOrdered bookOrdered = new BookOrdered(bookId, count);
                            order.BooksOrderedList.Add(bookOrdered);
                        }
                        else Console.WriteLine("We dont have that much books in stock");
                    }
                    else Console.WriteLine("Book with given ID does not exist in the repository, provide correct id again");




                }
                else if(command =="end")
                {   
                   _orderRepository.Insert(order);
                }
                else Console.WriteLine("Wrong command");

            }
        }
        public void ListAll()
        {
            var orders = _orderRepository.GetAll();
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

    }


}
