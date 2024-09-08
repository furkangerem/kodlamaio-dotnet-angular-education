using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;

// Dependecies
CarManager carManager = new CarManager(new EfCarDal());

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

foreach (Car eachCar in carManager.GetAllCarsByBrandId(1))
    Console.WriteLine(eachCar.BrandId + " - " + eachCar.DailyPrice + " - " + eachCar.ColorId + " - " + eachCar.Description);

foreach (Car eachCar in carManager.GetAllCarsByColorId(5))
    Console.WriteLine(eachCar.ColorId + " - " + eachCar.DailyPrice + " - " + eachCar.BrandId + " - " + eachCar.Description);

// Business Logic (Add)
// carManager.Add(carDesc);
// carManager.Add(carUp);
