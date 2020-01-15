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
<<<<<<< Updated upstream
        public IAccountDao AccountDao = new AccountDao();

        public IAccountParamConverter AccountParamConverter = new AccountParamConverter();

        public IAccountResultConverter AccountResultConverter = new AccountResultConverter();

        public AccountResult Create(AccountParam param)
        {

            Data.Entity.Account entity = AccountParamConverter.Convert(param, null);
            AccountDao.Save(entity);

            return AccountResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            List<Data.Entity.Account> entities = new List<Data.Entity.Account>();
            foreach (var item in param)
            {
                entities.Add(AccountParamConverter.Convert(item, null));
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

        public List<AccountResult> FindByField(string field, string value)
        {
            List<Data.Entity.Account> accounts = AccountDao.FindByField(field, value);
            List<AccountResult> results = new List<AccountResult>();
            foreach (var item in accounts)
            {
                results.Add(AccountResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, AccountParam param)
        {
            Data.Entity.Account oldEntity = AccountDao.Find(id);
            Data.Entity.Account newEntity = AccountParamConverter.Convert(param, null);
            AccountDao.Update(newEntity);
        }

        public void Update(List<AccountParam> param)
        {
            List<Data.Entity.Account> entity = new List<Data.Entity.Account>();
            foreach(var item in param)
            {
                Data.Entity.Account oldEntity = AccountDao.Find(item.Id);
                Data.Entity.Account newEntity = AccountParamConverter.Convert(item, null);
                AccountDao.Update(newEntity);
            }
        }
=======
        //private IAccountParamConverter _accountParamConverter;
        //public IAccountParamConverter AccountParamConverter
        //{
        //    set => _accountParamConverter = value;
        //    get
        //    {
        //        if (_accountParamConverter == null)
        //        {
        //            _accountParamConverter = new AccountParamConverter();
        //            return _accountParamConverter;
        //        }
        //        else
        //        {
        //            return _accountParamConverter;
        //        }
        //    }
        //}

        //private IAccountResultConverter _accountResultConverter;
        //public IAccountResultConverter AccountResultConverter
        //{
        //    set => _accountResultConverter = value;
        //    get
        //    {
        //        if (_accountResultConverter == null)
        //        {
        //            _accountResultConverter = new AccountResultConverter();
        //            return _accountResultConverter;
        //        }
        //        else
        //        {
        //            return _accountResultConverter;
        //        }
        //    }
        //}

        //private IAccountDao _accountDao;
        //public IAccountDao AccountDataObject
        //{
        //    set => _accountDao = value;
        //    get
        //    {
        //        if (_accountDao == null)
        //        {
        //            _accountDao = new AccountDao();
        //            return _accountDao;
        //        }
        //        else
        //        {
        //            return _accountDao;
        //        }
        //    }
        //}


        //public AccountResult Create(AccountParam param)
        //{

        //    Data.Entity.Account entity = _accountParamConverter.Convert(param, null);

        //    _accountDao.Save(entity);

        //    return _accountResultConverter.Convert(entity);
        //}

        //public List<AccountResult> Create(List<AccountParam> param)
        //{
        //    List<Data.Entity.Account> entities = new List<Data.Entity.Account>();
        //    foreach (var item in param)
        //    {
        //        entities.Add(_accountParamConverter.Convert(item, null));
        //    }
        //    _accountDao.Save(entities);
        //    List<AccountResult> result = new List<AccountResult>();
        //    foreach (var item in entities)
        //    {
        //        result.Add(_accountResultConverter.Convert(item));
        //    }
        //    return result;
        //}

        //public void Delete(long id)
        //{
        //    _accountDao.Delete(id);
        //}

        //public void Delete(List<long> idList)
        //{
        //    List<Data.Entity.Account> entity = new List<Data.Entity.Account>();
        //    foreach (var id in idList)
        //    {
        //        entity.Add(_accountDao.Find(id));
        //    }
        //    foreach (var id in idList)
        //    {
        //        _accountDao.Delete(id);
        //    }
        //}

        //public AccountResult Find(long id)
        //{
        //    try
        //    {
        //        Data.Entity.Account entity = _accountDao.Find(id);
        //        AccountResult result = _accountResultConverter.Convert(entity);
        //        return result;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
            
        //}

        //public List<AccountResult> Find()
        //{
        //    List<Data.Entity.Account> accounts = _accountDao.Find();
        //    List<AccountResult> results = new List<AccountResult>();
        //    foreach (var item in accounts)
        //    {
        //        results.Add(_accountResultConverter.Convert(item));
        //    }
        //    return results;
        //}

        //public List<AccountResult> FindByField(string field, string value)
        //{
        //    List<Data.Entity.Account> accounts = _accountDao.FindByField(field, value);
        //    List<AccountResult> results = new List<AccountResult>();
        //    foreach (var item in accounts)
        //    {
        //        results.Add(_accountResultConverter.Convert(item));
        //    }
        //    return results;
        //}

        //public void Update(long id, AccountParam param)
        //{
        //    Data.Entity.Account oldEntity = _accountDao.Find(id);
        //    Data.Entity.Account newEntity = _accountParamConverter.Convert(param, oldEntity);
        //    _accountDao.Update(newEntity);
        //}

        //public void Update(List<AccountParam> param)
        //{
        //    List<Data.Entity.Account> entity = new List<Data.Entity.Account>();
        //    foreach(var item in param)
        //    {
        //        Data.Entity.Account oldEntity = _accountDao.Find(item.Id);
        //        Data.Entity.Account newEntity = _accountParamConverter.Convert(item, oldEntity);
        //        _accountDao.Update(newEntity);
        //    }
        //}
>>>>>>> Stashed changes
    }
}
