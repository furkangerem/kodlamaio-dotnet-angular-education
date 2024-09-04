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
            _iCarDal.Add(car);
            Console.WriteLine("The new car added to the list!");
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
            Console.WriteLine("Given car is deleted from the db!");
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public Car GetCarById(int carId)
        {
            return _iCarDal.GetCarById(carId);
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
            Console.WriteLine("Given car information is updated!");
        }
    }
}
