using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;
        ICategoryService _iCategoryService;

        public ProductManager(IProductDal iProductDal, ICategoryService iCategoryService)
        {
            _iProductDal = iProductDal;
            _iCategoryService = iCategoryService;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName),
                CheckIfProductCountOfCategoryCorrect(product.CategoryId), CheckIfCategoryLimitExceeded());
            if (result != null)
                return result;

            _iProductDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            // Business Codes
            if (DateTime.Now.Hour == 22)
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);

            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.CategoryId == categoryId));
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_iProductDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal minUnitPrice, decimal maxUnitPrice)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.UnitPrice >= minUnitPrice && p.UnitPrice <= maxUnitPrice));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_iProductDal.GetProductDetails());
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }

        // Business Rules
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _iProductDal.GetAll(product => product.CategoryId == product.CategoryId).Count;
            if (result >= 15)
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            return new SuccessResult();
        }

        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _iProductDal.GetAll(product => product.ProductName == productName).Any();
            if (result)
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            return new SuccessResult();
        }

        private IResult CheckIfCategoryLimitExceeded()
        {
            var result = _iCategoryService.GetAll();
            if (result.Data.Count > 15)
                return new ErrorResult(Messages.CategoryLimitExceeded);

            return new SuccessResult();
        }
    }
}
