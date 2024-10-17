using Business.Abstract;
using Core.Utilities.Results.Concretes;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Concretes.Success;
using Business.Constants;
using Core.Utilities.Results.Concretes.Errors;
using System.Drawing;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Car> GetCarById(int carId)
        {
            return new SuccessDataResult<Car>(_iCarDal.Get(car => car.Id == carId), Messages.CarFound);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _iCarDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            IDataResult<Car> tempCar = GetCarById(car.Id);
            if (tempCar.Data == null)
                return new ErrorResult(Messages.CarNotExist);

            tempCar.Data.Id = car.Id;
            tempCar.Data.BrandId = car.BrandId;
            tempCar.Data.ColorId = car.ColorId;
            tempCar.Data.Name = car.Name;
            tempCar.Data.ModelYear = car.ModelYear;
            tempCar.Data.DailyPrice = car.DailyPrice;
            tempCar.Data.Description = car.Description;

            _iCarDal.Update(tempCar.Data);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            IDataResult<Car> tempCar = GetCarById(car.Id);
            if (tempCar.Data == null)
                return new ErrorResult(Messages.CarNotExist);

            _iCarDal.Delete(tempCar.Data);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAllCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(car => car.BrandId == brandId), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(car => car.ColorId == colorId), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetails(), Messages.CarListed);
        }
    }
}