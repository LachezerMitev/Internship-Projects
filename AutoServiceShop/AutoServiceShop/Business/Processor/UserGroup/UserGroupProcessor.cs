using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Business.Processor.Converter.UserGroup;

namespace AutoServiceShop.Business.Processor.UserGroup
{
    class UserGroupProcessor : IUserGroupProcessor
    {
        private IUserGroupParamConverter _userGroupParamConverter;
        public IUserGroupParamConverter UserGroupParamConverter
        {
            set => _userGroupParamConverter = value;
            get
            {
                if (_userGroupParamConverter == null)
                {
                    _userGroupParamConverter = new UserGroupParamConverter();
                    return _userGroupParamConverter;
                }
                else
                {
                    return _userGroupParamConverter;
                }
            }
        }

        private IUserGroupResultConverter _userGroupResultConverter;
        public IUserGroupResultConverter UserGroupResultConverter
        {
            set => _userGroupResultConverter = value;
            get
            {
                if (_userGroupResultConverter == null)
                {
                    _userGroupResultConverter = new UserGroupResultConverter();
                    return _userGroupResultConverter;
                }
                else
                {
                    return _userGroupResultConverter;
                }
            }
        }

        private IUserGroupDao _userGroupDao;
        public IUserGroupDao UserGroupDataObject
        {
            set => _userGroupDao = value;
            get
            {
                if (_userGroupDao == null)
                {
                    _userGroupDao = new UserGroupDao();
                    return _userGroupDao;
                }
                else
                {
                    return _userGroupDao;
                }
            }
        }


        public UserGroupResult Create(UserGroupParam param)
        {

            Data.Entity.UserGroup entity = _userGroupParamConverter.Convert(param, null);

            _userGroupDao.Save(entity);

            return _userGroupResultConverter.Convert(entity);
        }

        public List<UserGroupResult> Create(List<UserGroupParam> param)
        {
            List<Data.Entity.UserGroup> entities = new List<Data.Entity.UserGroup>();
            foreach (var item in param)
            {
                entities.Add(_userGroupParamConverter.Convert(item, null));
            }
            _userGroupDao.Save(entities);
            List<UserGroupResult> result = new List<UserGroupResult>();
            foreach (var item in entities)
            {
                result.Add(_userGroupResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _userGroupDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.UserGroup> entity = new List<Data.Entity.UserGroup>();
            foreach (var id in idList)
            {
                entity.Add(_userGroupDao.Find(id));
            }
            foreach (var id in idList)
            {
                _userGroupDao.Delete(id);
            }
        }

        public UserGroupResult Find(long id)
        {
            try
            {
                Data.Entity.UserGroup entity = _userGroupDao.Find(id);
                UserGroupResult result = _userGroupResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<UserGroupResult> Find()
        {
            List<Data.Entity.UserGroup> UserGroups = _userGroupDao.Find();
            List<UserGroupResult> results = new List<UserGroupResult>();
            foreach (var item in UserGroups)
            {
                results.Add(_userGroupResultConverter.Convert(item));
            }
            return results;
        }

        public List<UserGroupResult> FindByField(string field, string value)
        {
            List<Data.Entity.UserGroup> UserGroups = _userGroupDao.FindByField(field, value);
            List<UserGroupResult> results = new List<UserGroupResult>();
            foreach (var item in UserGroups)
            {
                results.Add(_userGroupResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserGroupParam param)
        {
            Data.Entity.UserGroup oldEntity = _userGroupDao.Find(id);
            Data.Entity.UserGroup newEntity = _userGroupParamConverter.Convert(param, oldEntity);
            _userGroupDao.Update(newEntity);
        }

        public void Update(List<UserGroupParam> param)
        {
            List<Data.Entity.UserGroup> entity = new List<Data.Entity.UserGroup>();
            foreach (var item in param)
            {
                Data.Entity.UserGroup oldEntity = _userGroupDao.Find(item.Id);
                Data.Entity.UserGroup newEntity = _userGroupParamConverter.Convert(item, oldEntity);
                _userGroupDao.Update(newEntity);
            }
        }
    }
}
