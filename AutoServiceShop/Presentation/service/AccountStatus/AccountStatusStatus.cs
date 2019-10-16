using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.AccountStatus
{
    class AccountStatusStatus : IAccountStatusService
    {
        AccountStatusProcessor AccountStatusProcessor { get; set; }

        public ApiResponse Create(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<AccountStatusParam> param)
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

        public ApiResponse Update(long id, AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
