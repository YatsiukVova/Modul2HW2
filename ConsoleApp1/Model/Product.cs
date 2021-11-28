using System;

namespace ConsoleApp1.Model
{
    public class Product
    {
        public double Price { get; set; }
        public bool IsExist { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }
        public Currency Currency { get; set; }
    }
}
