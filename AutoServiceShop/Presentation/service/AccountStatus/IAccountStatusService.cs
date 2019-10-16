using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AutoServiceShop.Presentation.service.AccountStatus
{
    interface IAccountStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(AccountStatusParam param);
        ApiResponse Create(List<AccountStatusParam> param);

        ApiResponse Update(long id, AccountStatusParam param);
        ApiResponse Update(List<AccountStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(AccountStatusParam param);
        void ValidateParameters(List<AccountStatusParam> param);
    }
}
