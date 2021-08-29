using boodschApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boodschApplication.Services
{
    public class ShoppingItemFactory
    {
        public ShoppingItem CreateItem(string description, int quantity)
        {
            return new ShoppingItem(description, quantity);
        }
    }
}
