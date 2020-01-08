using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.User
{
    public interface IUserParamConverter : IBaseParamConverter<UserParam, Data.Entity.User>
    {
        //AutoServiceShop.Data.Entity.User Convert(UserParam param, Data.Entity.User oldentity);
    }
}
