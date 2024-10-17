using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Errors;
using Core.Utilities.Results.Concretes.Success;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _iBrandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_iBrandDal.GetAll(), Messages.BrandListed);
        }

        public IDataResult<Brand> GetBrandById(int brandId)
        {
            return new SuccessDataResult<Brand>(_iBrandDal.Get(brand => brand.Id == brandId), Messages.BrandFound);
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _iBrandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            IDataResult<Brand> tempBrand = GetBrandById(brand.Id);
            if (tempBrand.Data == null)
                return new ErrorResult(Messages.BrandNotExist);

            _iBrandDal.Delete(tempBrand.Data);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {
            IDataResult<Brand> tempBrand = GetBrandById(brand.Id);
            if (tempBrand == null)
                return new ErrorResult(Messages.BrandNotExist);

            tempBrand.Data.Id = brand.Id;
            tempBrand.Data.Name = brand.Name;
            _iBrandDal.Update(tempBrand.Data);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
