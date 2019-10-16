using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Account;
using Newtonsoft.Json;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountParamConverter : IAccountParamConverter
    {
        AccountDao AccountDao { get; set; }

        public Data.Entity.Account Convert(AccountParam param)
        {
            Data.Entity.Account convertedAccount = JsonConvert.DeserializeObject<Data.Entity.Account>(param.jsonString);

            return convertedAccount;
        }
    }
}
