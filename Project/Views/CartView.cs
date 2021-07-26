using Project.Entities.Product;
using System.Collections.Generic;
using System;
using Project.Services.ProductsService;

namespace Project.Views
{

    class CartView
    {
        Product product = new Product();
        ProductsService productservice = new ProductsService(); 
        public void Cart()
        {
            Console.WriteLine("-------Cart-------");
            productservice.AddCart(product.Name, product.Price, product.Quantity);
        }
      
    }
}
