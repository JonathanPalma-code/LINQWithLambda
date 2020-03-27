using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_with_Lambda.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nPrice: {Price.ToString("F2")}, Category name: {Category.Name}, Category Tier: {Category.Tier}";
        }
    }
}
