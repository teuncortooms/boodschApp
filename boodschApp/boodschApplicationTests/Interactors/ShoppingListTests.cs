using Microsoft.VisualStudio.TestTools.UnitTesting;
using boodschApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boodschApplication.Interfaces;
using Moq;

namespace boodschApplication.Entities.Tests
{
    [TestClass()]
    public class ShoppingListTests
    {
        [TestMethod()]
        public void Create_Shopping_List_With_Repo()
        {
            ShoppingList list = Create_Shopping_List_With_Generic_Items(); 

            Assert.IsInstanceOfType(list, typeof(ShoppingList));
        }

        private ShoppingList Create_Shopping_List(List<ShoppingItem> items)
        {
            var mock = new Mock<IShoppingItemRepository>();
            mock.SetupGet(x => x.ShoppingItems).Returns(items);

            return new ShoppingList(mock.Object);
        }

        private ShoppingList Create_Shopping_List_With_Generic_Items()
        {
            List<ShoppingItem> items = new()
            {
                new ShoppingItem("item 1", 1),
                new ShoppingItem("item 2", 1),
                new ShoppingItem("item 3", 5)
            };

            return Create_Shopping_List(items);
        }


        [TestMethod()]
        public void Create_Shopping_List_With_Null_Argument_Should_Throw_Exception()
        {
            ShoppingList list = new(null);

            Assert.IsInstanceOfType(list, typeof(ShoppingList));
        }


        [TestMethod()]
        public void Get_Items_Should_Return_List()
        {
            List<ShoppingItem> expected = new()
            {
                new ShoppingItem("expected 1", 1),
                new ShoppingItem("expected 2", 1),
                new ShoppingItem("expected 3", 5)
            };

            ShoppingList list = Create_Shopping_List(expected);

            Assert.AreEqual(expected, list.GetItems());
        }

        [TestMethod()]
        public void AddItemTest()
        {
            Assert.Fail();
        }
    }
}