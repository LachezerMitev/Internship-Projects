using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    class AccountStatusParamConvert : IAccountStatusParamConverter
    {
        public Data.Entity.AccountStatus Convert(AccountStatusParam param, Data.Entity.AccountStatus oldentity)
        {
            Data.Entity.AccountStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.AccountStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
            
            return entity;
        }
    }
}
