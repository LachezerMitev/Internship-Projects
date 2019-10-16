using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;

namespace AutoServiceShop.Business.Processor.Converter.UserGroupStatus
{
    class UserGroupStatusParamConverter : IUserGroupStatusParamConverter
    {
        UserGroupStatusDao UserGroupStatusDao { get; set; }

        public Data.Entity.UserGroupStatus Convert(UserGroupStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
