using System.Collections.Generic;

namespace boodschApplication.Interfaces
{
    public interface IShoppingItemRepository
    {
        List<ShoppingItem> ShoppingItems { get; }
        void AddItem(ShoppingItem item);
    }
}