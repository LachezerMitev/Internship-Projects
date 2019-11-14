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
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountParamConverter : BaseParamConverter<AccountParam, Data.Entity.Account>, IAccountParamConverter
    {
        IAccountDao AccountDao = new AccountDao();
        IUserDao UserDao = new UserDao();
        IAccountStatusDao AccountStatusDao = new AccountStatusDao();
        

        public Data.Entity.Account Convert(AccountParam param, Data.Entity.Account oldentity)
        {
            Data.Entity.Account entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.Account
                {
                    Id = param.Id,
                    Code = param.Code
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Account ConvertSpecific(AccountParam param, Data.Entity.Account entity)
        {
            entity.AccountStatus = AccountStatusDao.Find(param.AccountStatusId);
            entity.User = UserDao.Find(param.UserId);

            return entity;
        }
    }
}
