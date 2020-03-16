using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Business.Processor.Common;

namespace AutoServiceShop.Business.Processor.AccountStatus
{
    public class AccountStatusProcessor :
        BaseProcessor<IAccountStatusParamConverter, IAccountStatusResultConvert, AccountStatusParam, AccountStatusResult, IAccountStatusDao, long, Data.Entity.AccountStatus>, IAccountStatusProcessor
    {
<<<<<<< Updated upstream
        IAccountStatusDao AccountStatusDao = new AccountStatusDao();

        IAccountStatusParamConverter AccountStatusParamConvert = new AccountStatusParamConvert();
        IAccountStatusResultConvert AccountStatusResultConvert = new AccountStatusResultConvert();

        public AccountStatusResult Create(AccountStatusParam param)
        {
            Data.Entity.AccountStatus entity = AccountStatusParamConvert.Convert(param, null);
            AccountStatusDao.Save(entity);

            return AccountStatusResultConvert.Convert(entity);
        }

        public List<AccountStatusResult> Create(List<AccountStatusParam> param)
        {
            List<Data.Entity.AccountStatus> entities = new List<Data.Entity.AccountStatus>();
            foreach (var item in param)
            {
                entities.Add(AccountStatusParamConvert.Convert(item, null));
            }
            AccountStatusDao.Save(entities);
            List<AccountStatusResult> result = new List<AccountStatusResult>();
            foreach (var item in entities)
            {
                result.Add(AccountStatusResultConvert.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            AccountStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.AccountStatus> entity = new List<Data.Entity.AccountStatus>();
            foreach (var id in idList)
            {
                entity.Add(AccountStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                AccountStatusDao.Delete(id);
            }
        }

        public AccountStatusResult Find(long id)
        {
            Data.Entity.AccountStatus entity = AccountStatusDao.Find(id);
            AccountStatusResult result = AccountStatusResultConvert.Convert(entity);
            return result;
        }

        public List<AccountStatusResult> Find()
        {
            List<Data.Entity.AccountStatus> entity = AccountStatusDao.Find();
            List<AccountStatusResult> results = new List<AccountStatusResult>();
            foreach (var item in entity)
            {
                results.Add(AccountStatusResultConvert.Convert(item));
            }
            return results;
        }

        public void Update(long id, AccountStatusParam param)
        {
            Data.Entity.AccountStatus oldEntity = AccountStatusDao.Find(id);
            Data.Entity.AccountStatus newEntity = AccountStatusParamConvert.Convert(param, null);
            AccountStatusDao.Update(newEntity);
        }

        public void Update(List<AccountStatusParam> param)
=======
        
        public AccountStatusProcessor(IAccountStatusDao dao, IAccountStatusParamConverter paramConverter, IAccountStatusResultConvert resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
            List<Data.Entity.AccountStatus> entity = new List<Data.Entity.AccountStatus>();
            foreach (var item in param)
            {
                Data.Entity.AccountStatus oldEntity = AccountStatusDao.Find(item.Id);
                Data.Entity.AccountStatus newEntity = AccountStatusParamConvert.Convert(item, null);
                AccountStatusDao.Update(newEntity);
            }
        }
    }
}
