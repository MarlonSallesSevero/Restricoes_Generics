using System;
using System.Globalization;
namespace Entities
{
    internal class Product : IComparable
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name},{(Price, CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("This is not a Product");
            }
            Product prod2 = obj as Product;
            return Price.CompareTo(prod2.Price);
        }
    }
}
