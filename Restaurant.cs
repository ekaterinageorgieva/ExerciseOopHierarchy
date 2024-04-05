﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<MenuItem> _menu = new();
        private List<Customer> _customers = new();


        public void AddCustomer(Customer customer)
        {
            this._customers.Add(customer);
        }

        public MenuItem GetMenuItem(int index)
        {
            if (index < 0 || index > _menu.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            return _menu[index];
        }

        public void AddMenuItem(MenuItem item)
        {
            this._menu.Add(item);
        }

        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach (MenuItem item in _menu) 
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");
            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: ${order.GetTotal()}");
                foreach (MenuItem item in order.Items)
                {
                    Console.WriteLine($"  {item}");
                }
            }
            
        }
    }
}
