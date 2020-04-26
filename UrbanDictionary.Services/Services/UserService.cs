﻿
using System.Linq;
using UrbanDictionary.BussinessLayer.Services.Contracts;
using UrbanDictionary.DataAccess.Entities;
using UrbanDictionary.DataAccess.Repositories.Contracts;

namespace UrbanDictionary.BussinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public UserService(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public User GetByUsername(string username)
        {
            return _repoWrapper.User.FindByCondition(i => i.UserName == username)?.FirstOrDefault();
        }

    }
}
