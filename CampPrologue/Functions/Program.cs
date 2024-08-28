using Functions;

Product product = new Product();
product.name = "iPhone 15";
product.description = "Apple iPhone 15 Cellphone";
product.price = 999;
product.stockAmount = 10;

Product product1 = new Product();
product1.name = "iPhone 14";
product1.description = "Apple iPhone 14 Cellphone";
product1.price = 799;
product1.stockAmount = 10;

Product[] products = new Product[] { product, product1 };
foreach (Product eachProduct in products)
{
    Console.WriteLine(eachProduct.name + ", " + eachProduct.description + " - " + eachProduct.price);
}

// Best practice.
CartManager cartManager = new CartManager();
cartManager.addToCart(product);
cartManager.addToCart(product1);

// Not supported way.
cartManager.addToCart("iPhone 15", "Apple iPhone 15 Cellphone", 999, 10);
cartManager.addToCart("iPhone 14", "Apple iPhone 14 Cellphone", 799, 10);