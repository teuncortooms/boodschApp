using boodschApplication.Entities;
using boodschApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boodschApplication.Interactors
{
    public class ShoppingList
    {
        private readonly IShoppingItemRepository repository;

        public ShoppingList(IShoppingItemRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public List<ShoppingItem> GetItems()
        {
            return repository.ShoppingItems;
        }

        public void AddItem(ShoppingItem item)
        {
            repository.AddItem(item);
        }
    }
}
