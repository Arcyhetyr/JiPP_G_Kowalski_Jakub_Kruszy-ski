using System;
using Library.Domain;
using Library.Persistence;

namespace Library.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Ślepnąc od świateł", "Jakub Żulczyk", 2015, "ISBN", 10, 19.99m);
            BooksRepository repository = new BooksRepository();
            while (true)
            {
                Console.WriteLine("Type your Login:");
                string login = Console.ReadLine();
                Console.WriteLine("Type your password");
                string password = Console.ReadLine();
                if (login != "Admin" && password != "password")
                {
                    Console.WriteLine("Access Denied");

                }
                else
                {
                    Console.WriteLine("Access Granted");
                
                string command;
                    BooksService Boook = new BooksService();
                    while (true)
                    {
                        // Console.Clear();
                        Console.WriteLine("Add - add a book");
                        Console.WriteLine("Del - delete a book");
                        Console.WriteLine("View - Display all books");
                        Console.WriteLine("Change - change the stock of a book");
                        Console.WriteLine("Add an order - add a new order");
                        Console.WriteLine("Order list - display all orders");
                        Console.WriteLine("Exit - exit the program");
                        Console.WriteLine();
                        Console.WriteLine("Type your command");
                        command = Console.ReadLine();
                        if (command == "exit")
                        {
                            Console.WriteLine("Im leaving, bye!");
                            break;
                        }
                        string continue_while;
                        Console.WriteLine("Do you want to exit menu?(yes/no)");
                        continue_while = Console.ReadLine();
                        if (continue_while == "yes")
                        {
                            Console.WriteLine("Im leaving, bye!");
                            break;
                        }

                        else
                        {

                            if (command == "add")
                            {
                                Console.WriteLine("Attempt to add a book");
                                Boook.AddBook();




                            }
                            if (command == "del")
                            {
                                Console.WriteLine("Attempt to delete a book");
                                Boook.RemoveBook();
                            }
                            if (command == "view")
                            {
                                Console.WriteLine("Attemt to Display all books");
                                Boook.ListBooks();
                            }
                            if (command == "change")
                            {
                                Console.WriteLine("Attempt to change the stock: ");
                                Boook.ChangeState();
                            }
                            if (command == "add an order")
                            {
                                Console.WriteLine("Attemt to add an order");
                            }
                            if (command == "order list")
                            {
                                Console.WriteLine("Attemt to display all orders");
                            }

                            else break;
                        }
                    }


                }break;


            }

        }
    }
}
