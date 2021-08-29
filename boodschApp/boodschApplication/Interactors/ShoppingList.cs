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
            if (repository == null) throw new ArgumentNullException();
            this.repository = repository;
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
