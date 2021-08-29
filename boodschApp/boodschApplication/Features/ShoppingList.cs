using boodschApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boodschApplication.Entities
{
    public class ShoppingList
    {
        private readonly IShoppingItemRepository repository;

        public ShoppingList(IShoppingItemRepository repository)
        {
            this.repository = repository;
        }

        public void AddItem(ShoppingItem item)
        {
            repository.AddItem(item);
        }
    }
}
