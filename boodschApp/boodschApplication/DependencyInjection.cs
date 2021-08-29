using boodschApplication.Interactors;
using boodschApplication.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boodschApplication
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<ShoppingList>();
            services.AddSingleton<ShoppingItemFactory>();
        }
    }
}
