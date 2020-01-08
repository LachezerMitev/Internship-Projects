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
<<<<<<< Updated upstream
        IUserDao UserDao { get; set; }
=======
        public override void ConvertSpecific(UserParam param, Data.Entity.User entity) { }
>>>>>>> Stashed changes

        public override Data.Entity.User GetResult(UserParam param)
        {
            Data.Entity.User entity = new Data.Entity.User
            {
                Id = param.Id
            };

            return entity;
        }
    }
}
