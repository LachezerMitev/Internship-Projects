using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Business.Processor.Converter.User;

namespace AutoServiceShop.Business.Processor.User
{
    class UserProcessor : IUserProcessor
    {
        private IUserParamConverter _userParamConverter;
        public IUserParamConverter UserParamConverter
        {
            set => _userParamConverter = value;
            get
            {
                if (_userParamConverter == null)
                {
                    _userParamConverter = new UserParamConverter();
                    return _userParamConverter;
                }
                else
                {
                    return _userParamConverter;
                }
            }
        }

        private IUserResultConverter _userResultConverter;
        public IUserResultConverter UserResultConverter
        {
            set => _userResultConverter = value;
            get
            {
                if (_userResultConverter == null)
                {
                    _userResultConverter = new UserResultConverter();
                    return _userResultConverter;
                }
                else
                {
                    return _userResultConverter;
                }
            }
        }

        private IUserDao _userDao;
        public IUserDao UserDataObject
        {
            set => _userDao = value;
            get
            {
                if (_userDao == null)
                {
                    _userDao = new UserDao();
                    return _userDao;
                }
                else
                {
                    return _userDao;
                }
            }
        }


        public UserResult Create(UserParam param)
        {

            Data.Entity.User entity = _userParamConverter.Convert(param, null);

            _userDao.Save(entity);

            return _userResultConverter.Convert(entity);
        }

        public List<UserResult> Create(List<UserParam> param)
        {
            List<Data.Entity.User> entities = new List<Data.Entity.User>();
            foreach (var item in param)
            {
                entities.Add(_userParamConverter.Convert(item, null));
            }
            _userDao.Save(entities);
            List<UserResult> result = new List<UserResult>();
            foreach (var item in entities)
            {
                result.Add(_userResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _userDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.User> entity = new List<Data.Entity.User>();
            foreach (var id in idList)
            {
                entity.Add(_userDao.Find(id));
            }
            foreach (var id in idList)
            {
                _userDao.Delete(id);
            }
        }

        public UserResult Find(long id)
        {
            try
            {
                Data.Entity.User entity = _userDao.Find(id);
                UserResult result = _userResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<UserResult> Find()
        {
            List<Data.Entity.User> Users = _userDao.Find();
            List<UserResult> results = new List<UserResult>();
            foreach (var item in Users)
            {
                results.Add(_userResultConverter.Convert(item));
            }
            return results;
        }

        public List<UserResult> FindByField(string field, string value)
        {
            List<Data.Entity.User> Users = _userDao.FindByField(field, value);
            List<UserResult> results = new List<UserResult>();
            foreach (var item in Users)
            {
                results.Add(_userResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserParam param)
        {
            Data.Entity.User oldEntity = _userDao.Find(id);
            Data.Entity.User newEntity = _userParamConverter.Convert(param, oldEntity);
            _userDao.Update(newEntity);
        }

        public void Update(List<UserParam> param)
        {
            List<Data.Entity.User> entity = new List<Data.Entity.User>();
            foreach (var item in param)
            {
                Data.Entity.User oldEntity = _userDao.Find(item.Id);
                Data.Entity.User newEntity = _userParamConverter.Convert(item, oldEntity);
                _userDao.Update(newEntity);
            }
        }
    }
}
