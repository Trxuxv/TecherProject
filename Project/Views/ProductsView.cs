using System;
using System.Collections.Generic;
using Project.Entities.Product;
using Project.Services.ProductsService;

namespace Project.Views.Products
{
    public class ProductsView
    {
        ProductsService productsservice = new ProductsService();
        Product product = new Product();
        CartView cartview = new CartView();
        public void ShowProductsList()
        {
            //List of computers
            List<Product> computers = new List<Product>();
            computers.Add(new Product() 
            { 
                Name = "#1 Computer Intel Core I5 8Gb Hd 500Gb Monitor Hdm", 
                Price = 3899,
                Detail = "Marca: Acer -- Sistema Operacional: Windows 10 Home -- Memória: 8GB",
                Category = Enums.Category.Computer,
                Quantity = 26
            });
            computers.Add(new Product() { Name = "#2 Computer Desktop Intel Core i5 3.2Ghz/ 10GB DDR3 / HD 500GB", Price = 2999 });

            //List of notebooks
            List<Product> notebooks = new List<Product>();
            notebooks.Add(new Product()
            {
                Name = "Notebook Acer Ryzen 7 8GB 256 SSD",
                Price = 3.899                
            });

            notebooks.Add(new Product() { Name = "Notebook Acer Ryzen 3 8GB 1TB 15,6", Price = 2.999 });
            notebooks.Add(new Product() { Name = "Notebook Acer Core i5 8GB 1TBHD+128GB SSD", Price = 4.299 });
            notebooks.Add(new Product() { Name = "Notebook Acer Core i5 8GB 512GB SSD", Price = 3129.00 });
            notebooks.Add(new Product() { Name = "Notebook Acer Core i3 4GB 256GB SSD", Price = 3599.00 });
            notebooks.Add(new Product() { Name = "Notebook Asus Celeron 4GB 500GB", Price = 2299.00 });

            //List of acessories
            List<Product> acessories = new List<Product>();
            acessories.Add(new Product() { Name = "Notebook Acer Ryzen 7 8GB 256 SSD", Price = 3.899 });

            //List of smartphones
            List<Product> smartphones = new List<Product>();
            smartphones.Add(new Product() { Name = "Smartphone Motorola Moto G20 64GB Blue", Price = 1098.00 });
            smartphones.Add(new Product() { Name = "Smartphone Samsung A32 128GB Violet", Price = 1459.00 });

            //List of tablets
            List<Product> tablets = new List<Product>();
            tablets.Add(new Product() { Name = "Tablet Samsung Galaxy Tab A T290 Wi-Fi 32Gb Android 9.0 ", Price = 848 });

            //Page choose
            Console.Write("Type the page: ");
            int pageSwitch = int.Parse(Console.ReadLine());

            switch (pageSwitch)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("-----------Computer-----------");
                    computers.ForEach(c =>{ var texto = $"{c.Name} - R${c.Price}";
                    Console.WriteLine(texto);
                    });
                    Console.WriteLine();
                    Console.Write("Choose the computer: ");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (c)
                    {
                        case 1:
                            var cc = computers.Find(cc => (cc.Name.Contains("#1")));
                            { 
                                var text = 
                                    $"" +
                                    $"{cc.Name} - R$" +
                                    $"{cc.Price}  \r\n " +
                                    $"---------Details--------\r\n  " +
                                    $"{cc.Detail} \r\n "  +
                                    $" Category: {cc.Category}";
                                  
                                 Console.WriteLine(text);
                            };
                            Console.WriteLine("Add to cart ? Y/N");
                            string a1 = Console.ReadLine();

                            if (a1 == "Y" || a1 == "y")
                            {
                                productsservice.AddCart(cc.Name, cc.Price, cc.Quantity);
                                Console.WriteLine("Added with success");
                                
                                Console.Write("Go to cart page ? Y/N ");
                                string a2 = Console.ReadLine();

                                if ( a2 == "Y" || a2 == "y")
                                {
                                    cartview.Cart();
                                }
                            }
                            else if (a1 == "N" || a1 == "n")
                            {
                                Console.WriteLine("Back to the products");
                            }


                            break;

                        case 2:
                            var c2 = computers.Find(c2 => (c2.Name.Contains("#2")));
                            {
                                var text = $"{c2.Name} - R${c2.Price}";
                                Console.WriteLine(text);
                            };
                            break;
                    }

                    break;
                case 3:
                    Console.WriteLine("-----------Notebooks----------");
                    notebooks.ForEach(n =>
                    {
                        var text = $"{n.Name} - R${n.Price}";
                        Console.WriteLine(text);
                    });
                    break;
                case 4:
                    Console.WriteLine("-----------Acessories----------");
                    acessories.ForEach(n =>
                    {
                        var text = $"{n.Name} - R${n.Price}";
                        Console.WriteLine(text);
                    });
                    break;
                case 5:
                    Console.WriteLine("-----------Smartphones----------");
                    smartphones.ForEach(s =>
                    {
                        var text = $"{s.Name} - R${s.Price}";
                        Console.WriteLine(text);
                    });
                    break;
                case 6:
                    Console.WriteLine("-----------Tablets----------");
                    tablets.ForEach(t =>
                    {
                        var text = $"{t.Name} - R${t.Price}";
                        Console.WriteLine(text);
                    });
                    break;
                default:
                    Console.WriteLine("Home");
                    break;
            }
        }
    }
}

