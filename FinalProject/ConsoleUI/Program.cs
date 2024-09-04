using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ProductManager productManager = new ProductManager(new InMemoryProductDal());
foreach (Product eachProduct in productManager.GetAll())
    Console.WriteLine(eachProduct.ProductName);