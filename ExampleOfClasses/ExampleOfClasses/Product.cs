using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOfClasses
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name)
        {
            Name = name;
        }
        public Product(decimal price)
        {
            Price = price;
        }
    }
}
