using System;

namespace boodschApplication
{
    public class Product
    {
        public string Name { get; private set; }
        public string Image { get; private set; } 


        public Product(string name)
        {
            Name = name;
        }
    }
}
