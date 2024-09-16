using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetCarById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAllCarsByBrandId(int brandId);
        List<Car> GetAllCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
