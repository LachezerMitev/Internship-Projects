using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Account
{
    class AccountService : IAccountService
    {
        public AccountProcessor AccountProcessor { get; set; }

        public ApiResponse Create(AccountParam param)
        {
            
            AccountProcessor.Create(param);

            ApiResponse response = new ApiResponse
            {
                text = "Well something happend. I think it worked :/",
                result = true
            };

            return response;
        }

        public ApiResponse Create(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, AccountParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
