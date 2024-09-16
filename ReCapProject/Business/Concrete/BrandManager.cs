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
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _iBrandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _iBrandDal.GetAll();
        }

        public Brand GetBrandById(int brandId)
        {
            return _iBrandDal.Get(brand => brand.BrandId == brandId);
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length <= 3)
                throw new Exception("The length of the brand name must be at least 3 characters!");

            _iBrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand tempBrand = GetBrandById(brand.BrandId);
            if (tempBrand == null)
                throw new Exception("You can not delete nonexisting brand!");

            _iBrandDal.Delete(tempBrand);
        }

        public void Update(Brand brand)
        {
            Brand tempBrand = GetBrandById(brand.BrandId);
            if (tempBrand == null)
                throw new Exception("You can not update nonexisting brand!");

            tempBrand.BrandId = brand.BrandId;
            tempBrand.BrandName = brand.BrandName;
            _iBrandDal.Update(tempBrand);
        }
    }
}
