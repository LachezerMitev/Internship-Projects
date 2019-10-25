using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.UserGroupStatus
{
    class UserGroupStatusResultConverter : IUserGroupStatusResultConverter
    {
        public UserGroupStatusResult Convert(Data.Entity.UserGroupStatus param)
        {
            UserGroupStatusResult result = new UserGroupStatusResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
