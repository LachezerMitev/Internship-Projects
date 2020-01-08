using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    public interface IAccountStatusResultConvert : IBaseResultConverter<Data.Entity.AccountStatus, AccountStatusResult>
    {
        //AccountStatusResult Convert(AutoServiceShop.Data.Entity.AccountStatus param);
    }
}
