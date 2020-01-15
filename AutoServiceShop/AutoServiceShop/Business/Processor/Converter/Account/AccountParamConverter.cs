using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Account;
using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using Newtonsoft.Json;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountParamConverter : IAccountParamConverter
    {
<<<<<<< Updated upstream
        IAccountDao AccountDao = new AccountDao();
        IUserDao UserDao = new UserDao();
        IAccountStatusDao AccountStatusDao = new AccountStatusDao();

        public Data.Entity.Account Convert(AccountParam param, Data.Entity.Account oldentity)
=======

        private IUserDao _userDao;
        public IUserDao UserDao
        {
            
            set { _userDao = value; }

            get
            {
                if (_userDao == null)
                {
                    return _userDao;
                }
                else
                {
                    return _userDao;
                }
            }
        }

        private IAccountStatusDao _accountStatusDao; 
        public IAccountStatusDao AccountStatusDao
>>>>>>> Stashed changes
        {
            Data.Entity.Account entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
<<<<<<< Updated upstream
            else
            {
                entity = new Data.Entity.Account
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.FirstName = param.FirstName;
            entity.Surname = param.Surname;
            entity.LastName = param.LastName;
            entity.Type = param.Type;
            entity.User = UserDao.Find(param.UserId);
            entity.AccountStatus = AccountStatusDao.Find(param.AccountStatusId);
=======
        }

        private IAccountTypeDao _accountTypeDao;
        public IAccountTypeDao AccountTypeDao
        {

            set => _accountTypeDao = value;

            get
            {
                if (_accountTypeDao == null)
                {
                    return _accountTypeDao;
                }
                else
                {
                    return _accountTypeDao;
                }
            }
        }

        public override void ConvertSpecific(AccountParam param, Data.Entity.Account entity)
        {
            entity.AccountStatus = _accountStatusDao.Find(param.AccountStatusId);
            entity.User = _userDao.Find(param.UserId);
            entity.AccountType = _accountTypeDao.Find(param.AccountTypeId);
        }

        public override Data.Entity.Account GetResult(AccountParam param)
        {
            Data.Entity.Account entity = new Data.Entity.Account
            {
                Code = param.Code,
                Id = param.Id,
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
