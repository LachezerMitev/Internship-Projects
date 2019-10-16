using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.AccountStatus;

namespace AutoServiceShop.Business.Processor.AccountStatus
{
    interface IAccountStatusProcessor
    {
        AccountStatusResult Create(AccountStatusParam param);
        List<AccountStatusResult> Create(List<AccountStatusParam> param);

        void Update(long id, AccountStatusParam param);
        void Update(List<AccountStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        AccountStatusResult Find(long id);
        List<AccountStatusResult> Find();
    }
}
