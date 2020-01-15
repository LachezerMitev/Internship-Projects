using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.User;

namespace AutoServiceShop.Business.Processor.Converter.User
{
    class UserParamConverter : IUserParamConverter
    {
<<<<<<< Updated upstream
        IUserDao UserDao { get; set; }
=======
        public override void ConvertSpecific(UserParam param, Data.Entity.User entity) { }
>>>>>>> Stashed changes

        public Data.Entity.User Convert(UserParam param, Data.Entity.User oldentity)
        {
            Data.Entity.User entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.User
                {
                    Id = param.Id
                };
            }
            
            entity.Password = param.Password;
            entity.Username = param.Username;

            return entity;
        }
    }
}
