using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.User;

namespace AutoServiceShop.Business.Processor.Converter.User
{
    class UserParamConverter : BaseParamConverter<UserParam, Data.Entity.User>, IUserParamConverter
    {
        IUserDao UserDao { get; set; }

        public Data.Entity.User Convert(UserParam param, Data.Entity.User oldentity)
        {
            Data.Entity.User entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.User
                {
                    Id = param.Id
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.User ConvertSpecific(UserParam param, Data.Entity.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
