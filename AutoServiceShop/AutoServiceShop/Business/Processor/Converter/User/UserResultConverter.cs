using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.User
{
    class UserResultConverter : IUserResultConverter
    {
        public UserResult Convert(Data.Entity.User param)
        {
            UserResult result = new UserResult()
            {
                Id = param.Id,

                Username = param.Username,
                Password = param.Password
            };

            return result;
        }
    }
}
