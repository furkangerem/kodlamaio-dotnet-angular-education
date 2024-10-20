using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

// ProductTest();
// CategoryTest();
ProductDetailsTest();
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
    var result = productManager.GetByUnitPrice(40, 100);
    if (result.IsSuccess)
    {
        foreach (Product eachProduct in result.Data)
            Console.WriteLine(eachProduct.ProductName);
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (Category eachCategory in categoryManager.GetAllCategories().Data)
        Console.WriteLine(eachCategory.CategoryName);
}

static void ProductDetailsTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
    foreach (var eachProduct in productManager.GetProductDetails().Data)
        Console.WriteLine(eachProduct.ProductName + " - " + eachProduct.CategoryName);
}