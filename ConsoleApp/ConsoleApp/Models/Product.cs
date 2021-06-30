using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
   public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int Count { get; set; }
        public SalesItem SalesItem { get; set; }
        public int Code { get; set; }
        public Product(string name, double price , int count , int code , Category category)
        {
            Name = name;
            Price = price;
            Count = count;
            Code = code;
            Category = category;
        }
        public override string ToString()
        {
            return $"{Name},{Price},{Count},{Code},{Category}"; 
        }
    }
}
