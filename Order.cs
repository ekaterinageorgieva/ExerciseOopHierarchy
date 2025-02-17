﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> _items = new();

        public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();

        public void AddItem(MenuItem menuItem)
        {
            this._items.Add(menuItem);
        }

        public decimal GetTotal() 
        { 
            return this._items.Select(item => item.Price).Sum();
        }
    }
}
