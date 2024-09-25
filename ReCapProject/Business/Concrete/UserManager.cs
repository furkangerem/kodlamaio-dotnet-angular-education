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
    public class UserManager : IUserService
    {
        IUserDal _iUserDal;

        public UserManager(IUserDal iUserDal)
        {
            _iUserDal = iUserDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_iUserDal.GetAll(), Messages.UserListed);
        }

        public IDataResult<User> GetUserById(int userId)
        {
            return new SuccessDataResult<User>(_iUserDal.Get(user => user.Id == userId), Messages.UserFound);
        }

        public IResult Add(User user)
        {
            _iUserDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            IDataResult<User> foundUser = GetUserById(user.Id);
            if (foundUser == null)
                return new ErrorResult(Messages.UserNotExist);

            _iUserDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IResult Update(User user)
        {
            IDataResult<User> foundUser = GetUserById(user.Id);
            if (foundUser == null)
                return new ErrorResult(Messages.UserNotExist);

            _iUserDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
