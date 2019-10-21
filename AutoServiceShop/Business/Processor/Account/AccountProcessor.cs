using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Account;
using AutoServiceShop.Business.Processor.Converter.Account;
using Newtonsoft.Json;

namespace AutoServiceShop.Business.Processor.Account
{
    class AccountProcessor : IAccountProcessor
    {
        public AccountDao AccountDao { get; set; }

        public AccountParamConverter AccountParamConverter { get; set; }
        public AccountResultConverter AccountResultConverter { get; set; }

        public AccountResult Create(AccountParam param)
        {
            Data.Entity.Account entity = AccountParamConverter.Convert(param);
            AccountDao.Save(entity);

            return AccountResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            List<Data.Entity.Account> entities = new List<Data.Entity.Account>();
            foreach (var item in param)
            {
                entities.Add(AccountParamConverter.Convert(item));
            }
            AccountDao.Save(entities);
            List<AccountResult> result = new List<AccountResult>();
            foreach (var item in entities)
            {
                result.Add(AccountResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            AccountDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Account> entity = new List<Data.Entity.Account>();
            foreach (var id in idList)
            {
                entity.Add(AccountDao.Find(id));
            }
            foreach (var id in idList)
            {
                AccountDao.Delete(id);
            }
        }

        public AccountResult Find(long id)
        {
            Data.Entity.Account entity = AccountDao.Find(id);
            AccountResult result = AccountResultConverter.Convert(entity);
            return result;
        }

        public List<AccountResult> Find()
        {
            List<Data.Entity.Account> accounts = AccountDao.Find();
            List<AccountResult> results = new List<AccountResult>();
            foreach (var item in accounts)
            {
                results.Add(AccountResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
