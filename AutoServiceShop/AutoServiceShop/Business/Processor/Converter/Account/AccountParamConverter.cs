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
=======

        private IUserDao _userDao;
        public IUserDao UserDao
        {
            
            set { _userDao = value; }

            get
            {
                if (_userDao == null)
                {
                    _userDao = new UserDao();
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
        {

            set { _accountStatusDao = value; }

            get
            {
                if (_accountStatusDao == null)
                {
                    _accountStatusDao = new AccountStatusDao();
                    return _accountStatusDao;
                }
                else
                {
                    return _accountStatusDao;
                }
            }
        }

>>>>>>> Stashed changes

        public Data.Entity.Account Convert(AccountParam param, Data.Entity.Account oldentity)
        {
            Data.Entity.Account entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
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

<<<<<<< Updated upstream
            entity.FirstName = param.FirstName;
            entity.Surname = param.Surname;
            entity.LastName = param.LastName;
            entity.Type = param.Type;
            entity.User = UserDao.Find(param.UserId);
            entity.AccountStatus = AccountStatusDao.Find(param.AccountStatusId);
=======
            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Account ConvertSpecific(AccountParam param, Data.Entity.Account entity)
        {
            entity.AccountStatus = _accountStatusDao.Find(param.AccountStatusId);
            entity.User = _userDao.Find(param.UserId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
