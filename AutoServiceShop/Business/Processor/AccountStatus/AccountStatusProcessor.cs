using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;

namespace AutoServiceShop.Business.Processor.AccountStatus
{
    class AccountStatusProcessor : IAccountStatusProcessor
    {
        IAccountStatusDao AccountStatusDao { get; set; }

        IAccountStatusParamConverter AccountStatusParamConvert { get; set; }
        IAccountStatusResultConvert AccountStatusResultConvert { get; set; }

        public AccountStatusResult Create(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<AccountStatusResult> Create(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public AccountStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
