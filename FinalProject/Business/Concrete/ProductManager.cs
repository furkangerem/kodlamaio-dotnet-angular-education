using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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

        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 3)
                return new ErrorResult(Messages.ProductNameInvalid);

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
    }
}
