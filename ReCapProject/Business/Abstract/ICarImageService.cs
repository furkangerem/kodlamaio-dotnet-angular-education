using Core.Utilities.Results.Abstracts;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {

        IResult Add(IFormFile iFormFile, CarImage carImage);
        IResult Update(IFormFile iFormFile, CarImage carImage);
        IResult Delete(CarImage carImage);

        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetCarImageById(int carImageId);
        IDataResult<List<CarImage>> GetCarImageByCarId(int carId);
    }
}