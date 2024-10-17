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
    public class RentalManager : IRentalService
    {
        IRentalDal _iRentalDal;

        public RentalManager(IRentalDal iRentalDal)
        {
            _iRentalDal = iRentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_iRentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<Rental> GetRentalById(int carId)
        {
            return new SuccessDataResult<Rental>(_iRentalDal.Get(rental => rental.CarId == carId), Messages.RentalFound);
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            IDataResult<Rental> isCarRented = GetRentalById(rental.CarId);
            if (isCarRented != null && isCarRented.Data.ReturnDate == null)
                return new ErrorResult(Messages.RentalNotReturned);

            _iRentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            IDataResult<Rental> foundRental = GetRentalById(rental.Id);
            if (foundRental == null)
                return new ErrorResult(Messages.RentalNotExist);

            _iRentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IResult Update(Rental rental)
        {
            IDataResult<Rental> foundRental = GetRentalById(rental.Id);
            if (foundRental == null)
                return new ErrorResult(Messages.RentalNotExist);

            _iRentalDal.Update(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }
    }
}
