using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserGroup;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    class UserGroupParamConverter : IUserGroupParamConverter
    {
        IUserGroupDao UserGroupDao { get; set; }

        public Data.Entity.UserGroup Convert(UserGroupParam param)
        {
            throw new NotImplementedException();
        }
    }
}
