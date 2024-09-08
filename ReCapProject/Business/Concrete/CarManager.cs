using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
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
        public void Add(Car car)
        {

            if (car.DailyPrice < 1)
                throw new Exception("The daily rate for the car can't be 0!");
            if (car.Description.Length < 3)
                throw new Exception("The length of the detail field entered for the vehicle must be at least 2 characters!");

            _iCarDal.Add(car);
            Console.WriteLine("The new car added to the list!");
        }
        public List<Car> GetAllCarsByBrandId(int brandId)
        {
            return _iCarDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetAllCarsByColorId(int colorId)
        {
            return _iCarDal.GetAll(car => car.ColorId == colorId);
        }
    }
}
