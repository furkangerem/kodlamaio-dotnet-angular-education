﻿using Core.Utilities.Results.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}