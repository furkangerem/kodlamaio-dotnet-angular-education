using OOP1;

Product product = new Product();
product.id = 1;
product.name = "iPhone 15";
product.categoryId = 1;
product.unitPrice = 999;
product.unitsInStock = 10;

Product product1 = new Product { id = 2, name = "iPhone 14", categoryId = 1, unitPrice = 799, unitsInStock = 10 };

ProductManager productManager = new ProductManager();
productManager.add(product);
productManager.add(product1);
