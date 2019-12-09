using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;

namespace AutoServiceShop.Business.Processor.UserGroupStatus
{
    class UserGroupStatusProcessor : IUserGroupStatusProcessor
    {
        private IUserGroupStatusParamConverter _userGroupStatusParamConverter;
        public IUserGroupStatusParamConverter UserGroupStatusParamConverter
        {
            set => _userGroupStatusParamConverter = value;
            get
            {
                if (_userGroupStatusParamConverter == null)
                {
                    _userGroupStatusParamConverter = new UserGroupStatusParamConverter();
                    return _userGroupStatusParamConverter;
                }
                else
                {
                    return _userGroupStatusParamConverter;
                }
            }
        }

        private IUserGroupStatusResultConverter _userGroupStatusResultConverter;
        public IUserGroupStatusResultConverter UserGroupStatusResultConverter
        {
            set => _userGroupStatusResultConverter = value;
            get
            {
                if (_userGroupStatusResultConverter == null)
                {
                    _userGroupStatusResultConverter = new UserGroupStatusResultConverter();
                    return _userGroupStatusResultConverter;
                }
                else
                {
                    return _userGroupStatusResultConverter;
                }
            }
        }

        private IUserGroupStatusDao _userGroupStatusDao;
        public IUserGroupStatusDao UserGroupStatusDataObject
        {
            set => _userGroupStatusDao = value;
            get
            {
                if (_userGroupStatusDao == null)
                {
                    _userGroupStatusDao = new UserGroupStatusDao();
                    return _userGroupStatusDao;
                }
                else
                {
                    return _userGroupStatusDao;
                }
            }
        }


        public UserGroupStatusResult Create(UserGroupStatusParam param)
        {

            Data.Entity.UserGroupStatus entity = _userGroupStatusParamConverter.Convert(param, null);

            _userGroupStatusDao.Save(entity);

            return _userGroupStatusResultConverter.Convert(entity);
        }

        public List<UserGroupStatusResult> Create(List<UserGroupStatusParam> param)
        {
            List<Data.Entity.UserGroupStatus> entities = new List<Data.Entity.UserGroupStatus>();
            foreach (var item in param)
            {
                entities.Add(_userGroupStatusParamConverter.Convert(item, null));
            }
            _userGroupStatusDao.Save(entities);
            List<UserGroupStatusResult> result = new List<UserGroupStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_userGroupStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _userGroupStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.UserGroupStatus> entity = new List<Data.Entity.UserGroupStatus>();
            foreach (var id in idList)
            {
                entity.Add(_userGroupStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _userGroupStatusDao.Delete(id);
            }
        }

        public UserGroupStatusResult Find(long id)
        {
            try
            {
                Data.Entity.UserGroupStatus entity = _userGroupStatusDao.Find(id);
                UserGroupStatusResult result = _userGroupStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<UserGroupStatusResult> Find()
        {
            List<Data.Entity.UserGroupStatus> UserGroupStatuss = _userGroupStatusDao.Find();
            List<UserGroupStatusResult> results = new List<UserGroupStatusResult>();
            foreach (var item in UserGroupStatuss)
            {
                results.Add(_userGroupStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<UserGroupStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.UserGroupStatus> UserGroupStatuss = _userGroupStatusDao.FindByField(field, value);
            List<UserGroupStatusResult> results = new List<UserGroupStatusResult>();
            foreach (var item in UserGroupStatuss)
            {
                results.Add(_userGroupStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserGroupStatusParam param)
        {
            Data.Entity.UserGroupStatus oldEntity = _userGroupStatusDao.Find(id);
            Data.Entity.UserGroupStatus newEntity = _userGroupStatusParamConverter.Convert(param, oldEntity);
            _userGroupStatusDao.Update(newEntity);
        }

        public void Update(List<UserGroupStatusParam> param)
        {
            List<Data.Entity.UserGroupStatus> entity = new List<Data.Entity.UserGroupStatus>();
            foreach (var item in param)
            {
                Data.Entity.UserGroupStatus oldEntity = _userGroupStatusDao.Find(item.Id);
                Data.Entity.UserGroupStatus newEntity = _userGroupStatusParamConverter.Convert(item, oldEntity);
                _userGroupStatusDao.Update(newEntity);
            }
        }
    }
}
