using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;

// Dependecies
CarManager carManager = new CarManager(new EfCarDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());

// InMemory Solution
/*

// Initial Car List
foreach (Car eachCar in carManager.GetAll())
    Console.WriteLine(eachCar.Description + " - " + eachCar.ModelYear);

Console.WriteLine("---------------------------------------------");

// Test Value
Car car = new Car() { CarId = 6, BrandId = 6, ColorId = 1, ModelYear = 2020, DailyPrice = 600, Description = "Renault Clio" };
carManager.Add(car);

// After Adding a New Car
foreach (Car eachCar in carManager.GetAll())
    Console.WriteLine(eachCar.Description + " - " + eachCar.ModelYear);

Console.WriteLine("---------------------------------------------");

// Find the Car by it's ID
Car foundCar = carManager.GetCarById(car.CarId);
Console.WriteLine(foundCar.Description + " - " + foundCar.ModelYear);

Console.WriteLine("---------------------------------------------");

// Changing the Model Year of our Renault Clio; 2020 -> 2024
car.ModelYear = 2024;
carManager.Update(car);

// After Updated a Car
foreach (Car eachCar in carManager.GetAll())
    Console.WriteLine(eachCar.Description + " - " + eachCar.ModelYear);

Console.WriteLine("---------------------------------------------");

// Deleting a Car; Renault Clio with carId = 6
carManager.Delete(car);

// After Deleted a Car
foreach (Car eachCar in carManager.GetAll())
    Console.WriteLine(eachCar.Description + " - " + eachCar.ModelYear);

*/

// Test Value
/*
Car car = new Car
{
    CarId = 1,
    BrandId = 2,
    ColorId = 3,
    ModelYear = 2021,
    DailyPrice = 150.75,
    Description = "Luxury sedan, premium features"
};
*/

// Description Length test
/*
Car carDesc = new Car
{
    CarId = 1,
    BrandId = 2,
    ColorId = 3,
    ModelYear = 2021,
    DailyPrice = 150.75,
    Description = "A"
};

// Description DailyPrice test
Car carUp = new Car
{
    CarId = 1,
    BrandId = 2,
    ColorId = 3,
    ModelYear = 2021,
    DailyPrice = 0,
    Description = "Luxury sedan, premium features"
};
*/

// Business Logic (Add)
// carManager.Add(carDesc);
// carManager.Add(carUp);

/*
// CarManager Test (+)
// Test Value
Car car = new Car() { CarId = 6, Name = "Clio", BrandId = 1, ColorId = 5, ModelYear = 2020, DailyPrice = 600, Description = "Renault Clio" };
carManager.Add(car);

Console.WriteLine("---------------------------------------------");


Car foundCarById = carManager.GetCarById(6);
Console.WriteLine(foundCarById.BrandId + " - " + foundCarById.DailyPrice + " - " + foundCarById.ColorId + " - " + foundCarById.Description);

Console.WriteLine("---------------------------------------------");

foreach (Car eachCar in carManager.GetAll())
    Console.WriteLine(eachCar.BrandId + " - " + eachCar.DailyPrice + " - " + eachCar.ColorId + " - " + eachCar.Description);

Console.WriteLine("---------------------------------------------");

foreach (Car eachCar in carManager.GetAllCarsByBrandId(1))
    Console.WriteLine(eachCar.BrandId + " - " + eachCar.DailyPrice + " - " + eachCar.ColorId + " - " + eachCar.Description);

Console.WriteLine("---------------------------------------------");

foreach (Car eachCar in carManager.GetAllCarsByColorId(5))
    Console.WriteLine(eachCar.ColorId + " - " + eachCar.DailyPrice + " - " + eachCar.BrandId + " - " + eachCar.Description);

Console.WriteLine("---------------------------------------------");

// Update Car
car.Description = "Updated Value";
carManager.Update(car);

Console.WriteLine("---------------------------------------------");

// Delete Car
carManager.Delete(car);
*/

// ColorManager Test

// Color color = new Color() { ColorId = 6, ColorName = "Purple" };
/*
colorManager.Add(color);

Console.WriteLine("---------------------------------------------");

Color foundColorById = colorManager.GetColorById(6);
Console.WriteLine(foundColorById.ColorId + " - " + foundColorById.ColorName);

Console.WriteLine("---------------------------------------------");

foreach (Color eachColor in colorManager.GetAll())
    Console.WriteLine(eachColor.ColorId + " - " + eachColor.ColorName);

Console.WriteLine("---------------------------------------------");

color.ColorName = "Updated Color Name";
colorManager.Update(color);

Console.WriteLine("---------------------------------------------");
*/

// colorManager.Delete(color);

// BrandManager Test

// Brand brand = new Brand() { BrandId = 6, BrandName = "TOGG" };
/*
brandManager.Add(brand);

Console.WriteLine("---------------------------------------------");

Brand foundBrandById = brandManager.GetBrandById(6);
Console.WriteLine(foundBrandById.BrandId + " - " + foundBrandById.BrandName);

Console.WriteLine("---------------------------------------------");

foreach (Brand eachBrand in brandManager.GetAll())
    Console.WriteLine(eachBrand.BrandId + " - " + eachBrand.BrandName);

Console.WriteLine("---------------------------------------------");

brand.BrandName = "Updated Brand Name";
brandManager.Update(brand);

Console.WriteLine("---------------------------------------------");
*/

// brandManager.Delete(brand);

foreach (var eachCar in carManager.GetCarDetails())
    Console.WriteLine(eachCar.CarName + " - " + eachCar.BrandName + " - " + eachCar.ColorName + " - " + eachCar.DailyPrice);