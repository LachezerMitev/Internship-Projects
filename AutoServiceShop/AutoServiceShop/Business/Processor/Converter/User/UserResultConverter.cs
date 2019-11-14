using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.User
{
    class UserResultConverter : BaseResultConverter<Data.Entity.User, UserResult>, IUserResultConverter
    {
        public UserResult Convert(Data.Entity.User param)
        {
            UserResult result = new UserResult();

            ConverterStandart(param, result);

            return result;
        }

        public override UserResult ConvertSpecific(Data.Entity.User param, UserResult result)
        {
            throw new NotImplementedException();
        }
    }
}
