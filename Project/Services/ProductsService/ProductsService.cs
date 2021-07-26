using Project.Entities.Product;

namespace Project.Services.ProductsService
{
    public class ProductsService
    {
        Product product = new Product();

        public string AddCart(string name, double price, int quantity)
        {
            product.Name = name;
            product.Price += price;
            product.Quantity += quantity;
            return $" Nome {name}, {price}, {quantity} ";
        }

        public void ShowItemsCart()
        {
            System.Console.WriteLine();
        }

    }

}

