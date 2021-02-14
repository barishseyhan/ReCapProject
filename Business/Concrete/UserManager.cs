﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        
        public IResult Add(User user)
        {
            _userDal.Add(user);
            
            return new Result(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return new Result(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetUserById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        public IResult Update(User user)
        {
            if (user.FirstName.Length > 2 && user.LastName.Length > 2)
            {
                _userDal.Update(user);
               
                return new Result(Messages.UserUpdated);
            }
            return new ErrorResult(Messages.UserNameInvalid);
        }
    }
}