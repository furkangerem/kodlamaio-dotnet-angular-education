using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (Product eachProduct in productManager.GetByUnitPrice(40, 100))
    Console.WriteLine(eachProduct.ProductName);