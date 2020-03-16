using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;

namespace AutoServiceShop.Business.Processor.AccountStatus
{
    public interface IAccountStatusProcessor
        : IBaseProcessor<IAccountStatusParamConverter, IAccountStatusResultConvert, AccountStatusParam, AccountStatusResult, IAccountStatusDao, long, Data.Entity.AccountStatus>
    {
        //AccountStatusResult Create(AccountStatusParam param);
        //List<AccountStatusResult> Create(List<AccountStatusParam> param);

        //void Update(long id, AccountStatusParam param);
        //void Update(List<AccountStatusParam> param);

        //void Delete(long id);
        //void Delete(List<long> idList);

        //AccountStatusResult Find(long id);
        //List<AccountStatusResult> Find();
    }
}
