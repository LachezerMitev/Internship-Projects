using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;

namespace AutoServiceShop.Business.Processor.UserUserGroup
{
    class UserUserGroupProcessor : IUserUserGroupProcessor
    {
        private IUserUserGroupParamConverter _userUserGroupParamConverter;
        public IUserUserGroupParamConverter UserUserGroupParamConverter
        {
            set => _userUserGroupParamConverter = value;
            get
            {
                if (_userUserGroupParamConverter == null)
                {
                    _userUserGroupParamConverter = new UserUserGroupParamConverter();
                    return _userUserGroupParamConverter;
                }
                else
                {
                    return _userUserGroupParamConverter;
                }
            }
        }

        private IUserUserGroupResultConverter _userUserGroupResultConverter;
        public IUserUserGroupResultConverter UserUserGroupResultConverter
        {
            set => _userUserGroupResultConverter = value;
            get
            {
                if (_userUserGroupResultConverter == null)
                {
                    _userUserGroupResultConverter = new UserUserGroupResultConverter();
                    return _userUserGroupResultConverter;
                }
                else
                {
                    return _userUserGroupResultConverter;
                }
            }
        }

        private IUserUserGroupDao _userUserGroupDao;
        public IUserUserGroupDao UserUserGroupDataObject
        {
            set => _userUserGroupDao = value;
            get
            {
                if (_userUserGroupDao == null)
                {
                    _userUserGroupDao = new UserUserGroupDao();
                    return _userUserGroupDao;
                }
                else
                {
                    return _userUserGroupDao;
                }
            }
        }


        public UserUserGroupResult Create(UserUserGroupParam param)
        {

            Data.Entity.UserUserGroup entity = _userUserGroupParamConverter.Convert(param, null);

            _userUserGroupDao.Save(entity);

            return _userUserGroupResultConverter.Convert(entity);
        }

        public List<UserUserGroupResult> Create(List<UserUserGroupParam> param)
        {
            List<Data.Entity.UserUserGroup> entities = new List<Data.Entity.UserUserGroup>();
            foreach (var item in param)
            {
                entities.Add(_userUserGroupParamConverter.Convert(item, null));
            }
            _userUserGroupDao.Save(entities);
            List<UserUserGroupResult> result = new List<UserUserGroupResult>();
            foreach (var item in entities)
            {
                result.Add(_userUserGroupResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _userUserGroupDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.UserUserGroup> entity = new List<Data.Entity.UserUserGroup>();
            foreach (var id in idList)
            {
                entity.Add(_userUserGroupDao.Find(id));
            }
            foreach (var id in idList)
            {
                _userUserGroupDao.Delete(id);
            }
        }

        public UserUserGroupResult Find(long id)
        {
            try
            {
                Data.Entity.UserUserGroup entity = _userUserGroupDao.Find(id);
                UserUserGroupResult result = _userUserGroupResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<UserUserGroupResult> Find()
        {
            List<Data.Entity.UserUserGroup> UserUserGroups = _userUserGroupDao.Find();
            List<UserUserGroupResult> results = new List<UserUserGroupResult>();
            foreach (var item in UserUserGroups)
            {
                results.Add(_userUserGroupResultConverter.Convert(item));
            }
            return results;
        }

        public List<UserUserGroupResult> FindByField(string field, string value)
        {
            List<Data.Entity.UserUserGroup> UserUserGroups = _userUserGroupDao.FindByField(field, value);
            List<UserUserGroupResult> results = new List<UserUserGroupResult>();
            foreach (var item in UserUserGroups)
            {
                results.Add(_userUserGroupResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserUserGroupParam param)
        {
            Data.Entity.UserUserGroup oldEntity = _userUserGroupDao.Find(id);
            Data.Entity.UserUserGroup newEntity = _userUserGroupParamConverter.Convert(param, oldEntity);
            _userUserGroupDao.Update(newEntity);
        }

        public void Update(List<UserUserGroupParam> param)
        {
            List<Data.Entity.UserUserGroup> entity = new List<Data.Entity.UserUserGroup>();
            foreach (var item in param)
            {
                Data.Entity.UserUserGroup oldEntity = _userUserGroupDao.Find(item.Id);
                Data.Entity.UserUserGroup newEntity = _userUserGroupParamConverter.Convert(item, oldEntity);
                _userUserGroupDao.Update(newEntity);
            }
        }
    }
}
