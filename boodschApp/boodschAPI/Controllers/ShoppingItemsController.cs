using boodschApplication;
using boodschApplication.Entities;
using boodschApplication.Interactors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boodschAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingItemsController : ControllerBase
    {
        private readonly ILogger<ShoppingItemsController> _logger;
        private readonly ShoppingList shoppinglist;

        public ShoppingItemsController(ILogger<ShoppingItemsController> logger, ShoppingList shoppinglist)
        {
            _logger = logger;
            this.shoppinglist = shoppinglist;
        }

        [HttpGet]
        public IEnumerable<ShoppingItem> Get()
        {
            _logger.LogInformation("Retrieving items...");
            
            return shoppinglist.GetItems();
        }
    }
}
