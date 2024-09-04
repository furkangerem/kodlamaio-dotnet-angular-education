using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;

// Dependecies
CarManager carManager = new CarManager(new InMemoryCarDal());

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