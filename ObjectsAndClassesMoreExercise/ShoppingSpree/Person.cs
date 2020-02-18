using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        // name, money and a bag of products
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> Bag { get; set; } = new List<Product>();
    }
}
