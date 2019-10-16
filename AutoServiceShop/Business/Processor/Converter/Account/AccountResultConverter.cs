using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using Newtonsoft.Json;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountResultConverter : IAccountResultConverter
    {
        public AccountResult Convert(Data.Entity.Account param)
        {
            string output = JsonConvert.SerializeObject(param);

            AccountResult result = new AccountResult
            {
                jsonResult = output
            };

            return result;
        }
    }
}
