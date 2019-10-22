using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupParamConverter : IUserUserGroupParamConverter
    {
        IUserUserGroupDao UserUserGroupDao { get; set; }

        public Data.Entity.UserUserGroup Convert(UserUserGroupParam param)
        {
            throw new NotImplementedException();
        }
    }
}
