using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class CartManager
    { 
        // Best practice.
        public void addToCart(Product product) { 
            Console.WriteLine("Product is added to the Cart successfully! Details: " + product.name + ", " + product.description + " - " + product.price + " / " + product.stockAmount);
        }
        
        // Not supported way.
        public void addToCart(string productName, string productDescription, double productPrice, int productStockAmount)
        {
            Console.WriteLine("Product is added to the Cart successfully! Details: " + productName + ", " + productDescription + " - " + productPrice + " / " + productStockAmount);
        }

        // This two methods are right example of the Encapsulation.
    }
}
