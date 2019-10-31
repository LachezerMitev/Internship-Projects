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
        IAccountDao AccountDao = new AccountDao();
        IUserDao UserDao = new UserDao();
        IAccountStatusDao AccountStatusDao = new AccountStatusDao();

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

            entity.FirstName = param.FirstName;
            entity.Surname = param.Surname;
            entity.LastName = param.LastName;
            entity.Type = param.Type;
            entity.User = UserDao.Find(param.UserId);
            entity.AccountStatus = AccountStatusDao.Find(param.AccountStatusId);

            return entity;
        }
    }
}
