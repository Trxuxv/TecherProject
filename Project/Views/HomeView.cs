using System;
using Project.Views.Products;

namespace Project.Views
{
    class HomeView
    {
        public void Home() 
        {
            Console.WriteLine("--------Pages---------");
            Console.WriteLine("#1 Home: 1");
            Console.WriteLine("#2 Computer: 2");
            Console.WriteLine("#3 Notebooks: 3");
            Console.WriteLine("#4 Acessories: 4");
            Console.WriteLine("#5 Smartphones: 5");
            Console.WriteLine("#6 Tablets: 6");
            Console.WriteLine();

            ProductsView productservice = new ProductsView();
            productservice.ShowProductsList();
        } 
    }
}
