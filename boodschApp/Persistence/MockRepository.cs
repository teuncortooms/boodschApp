using boodschApplication;
using boodschApplication.Entities;
using boodschApplication.Interfaces;
using boodschApplication.Services;
using System;
using System.Collections.Generic;

namespace Persistence
{
    public class MockRepository : IShoppingItemRepository
    {
        private readonly ShoppingItemFactory factory;
        public List<ShoppingItem> ShoppingItems { get; private set; }

        public MockRepository(ShoppingItemFactory factory)
        {
            this.factory = factory;
            this.ShoppingItems = new();
            AddTestData();
        }

        private void AddTestData()
        {
            string[] items = { "Apple", "Cola bottle", "Carrot", "Pair of socks", "Spoon" };

            Random r = new();

            foreach (string item in items)
            {
                int quantity = r.Next(1, 5);
                AddItem(factory.CreateItem(item, quantity));
            }
        }
        
        public void AddItem(ShoppingItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            ShoppingItems.Add(item);
        }

    }
}
