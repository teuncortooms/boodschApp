﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boodschApplication.Services
{
    public class ShoppingItemFactory
    {
        public ShoppingItem CreateItem(string name, int quantity)
        {
            return new ShoppingItem(new Product(name), quantity);
        }
    }
}