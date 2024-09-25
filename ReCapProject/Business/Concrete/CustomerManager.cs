using Business.Abstract;
using Business.Constants;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _iCustomerDal;

        public CustomerManager(ICustomerDal iCustomerDal)
        {
            _iCustomerDal = iCustomerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_iCustomerDal.GetAll(), Messages.CustomerListed);
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            return new SuccessDataResult<Customer>(_iCustomerDal.Get(customer => customer.Id == customerId), Messages.CustomerFound);
        }

        public IResult Add(Customer customer)
        {
            _iCustomerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            IDataResult<Customer> foundCustomer = GetCustomerById(customer.Id);
            if (foundCustomer == null)
                return new ErrorResult(Messages.CustomerNotExist);

            _iCustomerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IResult Update(Customer customer)
        {
            IDataResult<Customer> foundCustomer = GetCustomerById(customer.Id);
            if (foundCustomer == null)
                return new ErrorResult(Messages.CustomerNotExist);

            foundCustomer.Data.UserId = customer.UserId;
            foundCustomer.Data.CompanyName = customer.CompanyName;

            _iCustomerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
