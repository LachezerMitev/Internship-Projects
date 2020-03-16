using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    class AccountStatusParamConvert : BaseParamConverter<AccountStatusParam, Data.Entity.AccountStatus>, IAccountStatusParamConverter
    {
<<<<<<< Updated upstream
        IAccountStatusDao AccountStatusDao = new AccountStatusDao();

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
            
=======
        
        public override void ConvertSpecific(AccountStatusParam param, Data.Entity.AccountStatus entity)
        {
        }

        public override Data.Entity.AccountStatus GetResult(AccountStatusParam param)
        {
            Data.Entity.AccountStatus entity = new Data.Entity.AccountStatus
            {
                Code = param.Code,
                Id = param.Id,
                Active = param.Active
            };

>>>>>>> Stashed changes
            return entity;
        }
    }
}
