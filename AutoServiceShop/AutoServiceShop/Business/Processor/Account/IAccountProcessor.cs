using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Dataaccess.Dao.Account;

namespace AutoServiceShop.Business.Processor.Account
{
    interface IAccountProcessor
    {

        AccountResult Create(AccountParam param);
        List<AccountResult> Create(List<AccountParam> param);

        void Update(long id, AccountParam param);
        void Update(List<AccountParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        AccountResult Find(long id);
        List<AccountResult> Find();
        List<AccountResult> FindByField(string field, string value);

    }
}
