using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.User
{
    public interface IUserResultConverter : IBaseResultConverter<Data.Entity.User, UserResult>
    {
        //UserResult Convert(AutoServiceShop.Data.Entity.User param);
    }
}
