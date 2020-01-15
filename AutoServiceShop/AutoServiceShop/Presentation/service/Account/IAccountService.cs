using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Account;
<<<<<<< Updated upstream
=======
using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Dataaccess.Dao.Account;
>>>>>>> Stashed changes

namespace AutoServiceShop.Presentation.service.Account
{
    interface IAccountService
    {
<<<<<<< Updated upstream
        ApiResponse FindByPK (long id);
        ApiResponse ListAll ();
        ApiResponse FindByField(string field, string value);

        ApiResponse Create (AccountParam param);
        ApiResponse Create (List<AccountParam> param);
=======

        //ApiResponse FindByPK (long id);
        //ApiResponse ListAll ();
        //ApiResponse FindByField(string field, string value);
>>>>>>> Stashed changes

        ApiResponse Update (long id, AccountParam param);
        ApiResponse Update (List<AccountParam> param);

        ApiResponse DeleteById (long id);
        ApiResponse Delete (List<long> idList);

        void ValidateParameters(AccountParam param);
        void ValidateParameters(List<AccountParam> param);
    }
}
