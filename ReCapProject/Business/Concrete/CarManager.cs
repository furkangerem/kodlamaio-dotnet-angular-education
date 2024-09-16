using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }
        public Car GetCarById(int carId)
        {
            return _iCarDal.Get(car => car.CarId == carId);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice < 1)
                throw new Exception("The daily rate for the car can't be 0!");
            if (car.Description.Length < 3)
                throw new Exception("The length of the detail field entered for the vehicle must be at least 2 characters!");

            _iCarDal.Add(car);
            Console.WriteLine("The new car added to the list!");
        }

        public void Update(Car car)
        {
            Car tempCar = GetCarById(car.CarId);
            if (tempCar == null)
                throw new Exception("You can not update nonexisting car!");

            tempCar.CarId = car.CarId;
            tempCar.BrandId = car.BrandId;
            tempCar.ColorId = car.ColorId;
            tempCar.Name = car.Name;
            tempCar.ModelYear = car.ModelYear;
            tempCar.DailyPrice = car.DailyPrice;
            tempCar.Description = car.Description;

            _iCarDal.Update(tempCar);
        }

        public void Delete(Car car)
        {
            Car tempCar = GetCarById(car.CarId);
            if (tempCar == null)
                throw new Exception("You can not delete nonexisting car!");

            _iCarDal.Delete(tempCar);
        }

        public List<Car> GetAllCarsByBrandId(int brandId)
        {
            return _iCarDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetAllCarsByColorId(int colorId)
        {
            return _iCarDal.GetAll(car => car.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _iCarDal.GetCarDetails();
        }
    }
}
