using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Auxiliaries.FileAuxiliary;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Errors;
using Core.Utilities.Results.Concretes.Success;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        public ICarImageDal _iCarImageDal;
        public IFileAuxiliary _iFileAuxiliary;

        public CarImageManager(ICarImageDal iCarImageDal, IFileAuxiliary iFileAuxiliary)
        {
            _iCarImageDal = iCarImageDal;
            _iFileAuxiliary = iFileAuxiliary;
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_iCarImageDal.GetAll(), Messages.CarImageListed);
        }

        public IDataResult<CarImage> GetCarImageById(int carImageId)
        {
            return new SuccessDataResult<CarImage>(_iCarImageDal.Get(carImage => carImage.Id == carImageId), Messages.CarImageFound);
        }

        IDataResult<List<CarImage>> ICarImageService.GetCarImageByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_iCarImageDal.GetAll(c => c.CarId == carId));
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile iFormFile, CarImage carImage)
        {
            carImage.ImagePath = _iFileAuxiliary.Upload(iFormFile, FilePath.ImagesPath);
            _iCarImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Update(IFormFile iFormFile, CarImage carImage)
        {
            carImage.ImagePath = _iFileAuxiliary.Update(iFormFile, FilePath.ImagesPath + carImage.ImagePath, FilePath.ImagesPath);
            IDataResult<CarImage> tempCarImage = GetCarImageById(carImage.Id);
            if (tempCarImage.Data == null)
                return new ErrorResult(Messages.CarImageNotExist);

            tempCarImage.Data.CarId = carImage.CarId;
            tempCarImage.Data.ImagePath = carImage.ImagePath;

            _iCarImageDal.Update(tempCarImage.Data);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        public IResult Delete(CarImage carImage)
        {
            _iFileAuxiliary.Delete(FilePath.ImagesPath + carImage.ImagePath);
            IDataResult<CarImage> tempCarImage = GetCarImageById(carImage.Id);
            if (tempCarImage.Data == null)
                return new ErrorResult(Messages.CarImageNotExist);

            _iCarImageDal.Delete(tempCarImage.Data);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        // Business Rules

        private IResult CheckIfCarImageLimitExceeded(int carId)
        {
            var result = _iCarImageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 4)
                return new ErrorResult(Messages.CarImageLimitExceeded);

            return new SuccessResult(Messages.CarImageAdded);
        }

        private IDataResult<List<CarImage>> GetDefaultCarImage(int carId)
        {
            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<CarImage>>(carImage);
        }
    }
}
