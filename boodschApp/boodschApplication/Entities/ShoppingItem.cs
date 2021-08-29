using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boodschApplication.Entities
{
    public class ShoppingItem
    {
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public Product Product { get; private set; }

        public ShoppingItem(string description, int quantity)
        {
            Description = description;
            Quantity = quantity;
        }
    }
}
