using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            // Mock Data
            _cars = new List<Car>()
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2017, DailyPrice = 300, Description = "Hyundai i20"},
                new Car{CarId = 2, BrandId = 2, ColorId = 1, ModelYear = 2019, DailyPrice = 500, Description = "Opel Astra"},
                new Car{CarId = 3, BrandId = 3, ColorId = 1, ModelYear = 2021, DailyPrice = 700, Description = "Volkswagen Golf"},
                new Car{CarId = 4, BrandId = 4, ColorId = 1, ModelYear = 2023, DailyPrice = 900, Description = "BMW 1.18"},
                new Car{CarId = 5, BrandId = 5, ColorId = 1, ModelYear = 2024, DailyPrice = 950, Description = "Mercedes A180"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            if (carToDelete != null)
                _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int carId)
        {
            Car carById = _cars.SingleOrDefault(c => c.CarId == carId);
            if (carById != null) return carById;
            else return null;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
