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
        UserDao UserDao { get; set; }

        public Data.Entity.User Convert(UserParam param)
        {
            throw new NotImplementedException();
        }
    }
}
