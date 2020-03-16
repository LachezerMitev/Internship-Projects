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
        public override void ConvertSpecific(Data.Entity.User param, UserResult result) { }
    }
}
