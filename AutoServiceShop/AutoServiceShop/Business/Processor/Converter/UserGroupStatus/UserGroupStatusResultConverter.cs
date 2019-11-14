using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.UserGroupStatus
{
    class UserGroupStatusResultConverter : BaseResultConverter<Data.Entity.UserGroupStatus, UserGroupStatusResult>, IUserGroupStatusResultConverter
    {
        public UserGroupStatusResult Convert(Data.Entity.UserGroupStatus param)
        {
            UserGroupStatusResult result = new UserGroupStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override UserGroupStatusResult ConvertSpecific(Data.Entity.UserGroupStatus param, UserGroupStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
