using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

// ProductTest();
// CategoryTest();
ProductDetailsTest();
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (Product eachProduct in productManager.GetByUnitPrice(40, 100))
        Console.WriteLine(eachProduct.ProductName);
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (Category eachCategory in categoryManager.GetAllCategories())
        Console.WriteLine(eachCategory.CategoryName);
}

static void ProductDetailsTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var eachProduct in productManager.GetProductDetails())
        Console.WriteLine(eachProduct.ProductName + " - " + eachProduct.CategoryName);
}