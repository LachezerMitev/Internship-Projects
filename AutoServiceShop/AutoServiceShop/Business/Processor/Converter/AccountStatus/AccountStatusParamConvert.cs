using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    class AccountStatusParamConvert : IAccountStatusParamConverter
    {
        AccountStatusDao AccountStatusDao { get; set; }

        public Data.Entity.AccountStatus Convert(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
