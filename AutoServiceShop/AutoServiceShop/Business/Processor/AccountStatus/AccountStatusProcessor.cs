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
        private IAccountStatusParamConverter _accountStatusParamConverter;
        public IAccountStatusParamConverter AccountStatusParamConverter
        {
            set => _accountStatusParamConverter = value;
            get
            {
                if (_accountStatusParamConverter == null)
                {
                    _accountStatusParamConverter = new AccountStatusParamConvert();
                    return _accountStatusParamConverter;
                }
                else
                {
                    return _accountStatusParamConverter;
                }
            }
        }

        private IAccountStatusResultConvert _accountStatusResultConverter;
        public IAccountStatusResultConvert AccountStatusResultConverter
        {
            set => _accountStatusResultConverter = value;
            get
            {
                if (_accountStatusResultConverter == null)
                {
                    _accountStatusResultConverter = new AccountStatusResultConvert();
                    return _accountStatusResultConverter;
                }
                else
                {
                    return _accountStatusResultConverter;
                }
            }
        }

        private IAccountStatusDao _accountStatusDao;
        public IAccountStatusDao AccountStatusDataObject
        {
            set => _accountStatusDao = value;
            get
            {
                if (_accountStatusDao == null)
                {
                    _accountStatusDao = new AccountStatusDao();
                    return _accountStatusDao;
                }
                else
                {
                    return _accountStatusDao;
                }
            }
        }


        public AccountStatusResult Create(AccountStatusParam param)
        {

            Data.Entity.AccountStatus entity = _accountStatusParamConverter.Convert(param, null);

            _accountStatusDao.Save(entity);

            return _accountStatusResultConverter.Convert(entity);
        }

        public List<AccountStatusResult> Create(List<AccountStatusParam> param)
        {
            List<Data.Entity.AccountStatus> entities = new List<Data.Entity.AccountStatus>();
            foreach (var item in param)
            {
                entities.Add(_accountStatusParamConverter.Convert(item, null));
            }
            _accountStatusDao.Save(entities);
            List<AccountStatusResult> result = new List<AccountStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_accountStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _accountStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.AccountStatus> entity = new List<Data.Entity.AccountStatus>();
            foreach (var id in idList)
            {
                entity.Add(_accountStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _accountStatusDao.Delete(id);
            }
        }

        public AccountStatusResult Find(long id)
        {
            try
            {
                Data.Entity.AccountStatus entity = _accountStatusDao.Find(id);
                AccountStatusResult result = _accountStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<AccountStatusResult> Find()
        {
            List<Data.Entity.AccountStatus> AccountStatuss = _accountStatusDao.Find();
            List<AccountStatusResult> results = new List<AccountStatusResult>();
            foreach (var item in AccountStatuss)
            {
                results.Add(_accountStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<AccountStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.AccountStatus> AccountStatuss = _accountStatusDao.FindByField(field, value);
            List<AccountStatusResult> results = new List<AccountStatusResult>();
            foreach (var item in AccountStatuss)
            {
                results.Add(_accountStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, AccountStatusParam param)
        {
            Data.Entity.AccountStatus oldEntity = _accountStatusDao.Find(id);
            Data.Entity.AccountStatus newEntity = _accountStatusParamConverter.Convert(param, oldEntity);
            _accountStatusDao.Update(newEntity);
        }

        public void Update(List<AccountStatusParam> param)
        {
            List<Data.Entity.AccountStatus> entity = new List<Data.Entity.AccountStatus>();
            foreach (var item in param)
            {
                Data.Entity.AccountStatus oldEntity = _accountStatusDao.Find(item.Id);
                Data.Entity.AccountStatus newEntity = _accountStatusParamConverter.Convert(item, oldEntity);
                _accountStatusDao.Update(newEntity);
            }
        }
    }
}
