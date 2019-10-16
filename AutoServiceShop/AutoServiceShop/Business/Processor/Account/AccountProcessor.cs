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
            //AccountDao.Save(entity);

            Console.WriteLine("Account: " + entity.FirstName + " " + entity.LastName);

            return AccountResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
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

        public AccountResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountResult> Find()
        {
            throw new NotImplementedException();
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
