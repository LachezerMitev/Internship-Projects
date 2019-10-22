using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Account;
using Newtonsoft.Json;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountParamConverter : IAccountParamConverter
    {
        IAccountDao AccountDao { get; set; }

        public Data.Entity.Account Convert(AccountParam param)
        {
            Data.Entity.Account result = new Data.Entity.Account()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,
                FirstName = param.FirstName,
                Surname = param.Surname,
                LastName = param.LastName,
                Type = param.Type
            };

            return result;
        }

        public Data.Entity.Account Convert(AccountParam param, Data.Entity.Account oldentity)
        {
            Data.Entity.Account entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Account();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;
            entity.FirstName = param.FirstName;
            entity.Surname = param.Surname;
            entity.LastName = param.LastName;
            entity.Type = param.Type;

            return entity;
        }
    }
}
