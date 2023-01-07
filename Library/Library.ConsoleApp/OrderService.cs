using System;
using Library.Domain;
using Library.Persistence;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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
            Console.WriteLine("add - add item to your order");
            Console.WriteLine("end - end your order");
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    Console.WriteLine("Type book id");
                    int bookId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type amount of books");
                    int count = int.Parse(Console.ReadLine());
                    // BookOrdered bookOrdered = new BookOrdered { BookId = bookId, NumberOrdered = count };
                    // order.BooksOrderedList.Add(bookOrdered);
                    BookOrdered bookOrdered = new BookOrdered(bookId, count);
                    order.BooksOrderedList.Add(bookOrdered);



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
                Console.WriteLine(orders);
            }
        }

    }


}
