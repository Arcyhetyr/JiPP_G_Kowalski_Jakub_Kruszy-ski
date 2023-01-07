using System;
using System.Collections.Generic;
using Library.Domain;
using Library.Persistence;
using System.Linq;

namespace Library.Persistence
{
    public class OrdersRepository
    {
        private readonly List<Order> _database = new List<Order>();
        public void Insert(Order order)
        {
            _database.Add(order);
        }

        public List<Order> GetAll()
                {
                    return _database;
                }
            }
        }
