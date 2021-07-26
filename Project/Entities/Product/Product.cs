using System;
using Project.Enums;

namespace Project.Entities.Product
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //Json Detail
        public string Detail { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
    }
}
