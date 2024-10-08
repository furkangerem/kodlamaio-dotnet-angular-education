﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails()
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                var result = from car in dbContext.Cars
                             join bnd in dbContext.Brands
                             on car.BrandId equals bnd.Id
                             join clr in dbContext.Colors
                             on car.ColorId equals clr.Id
                             select new CarDetailDto { CarName = car.Name, BrandName = bnd.Name, ColorName = clr.Name, DailyPrice = car.DailyPrice };
                return result.ToList();
            }
        }

    }
}
