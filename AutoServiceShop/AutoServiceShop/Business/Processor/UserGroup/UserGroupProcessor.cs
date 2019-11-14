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
        IUserGroupDao UserGroupDao = new UserGroupDao();

        IUserGroupParamConverter UserGroupParamConverter = new UserGroupParamConverter();
        IUserGroupResultConverter UserGroupResultConverter = new UserGroupResultConverter();

        public UserGroupResult Create(UserGroupParam param)
        {
            Data.Entity.UserGroup entity = UserGroupParamConverter.Convert(param, null);
            UserGroupDao.Save(entity);

            return UserGroupResultConverter.Convert(entity);
        }

        public List<UserGroupResult> Create(List<UserGroupParam> param)
        {
            List<Data.Entity.UserGroup> entities = new List<Data.Entity.UserGroup>();
            foreach (var item in param)
            {
                entities.Add(UserGroupParamConverter.Convert(item, null));
            }
            UserGroupDao.Save(entities);
            List<UserGroupResult> result = new List<UserGroupResult>();
            foreach (var item in entities)
            {
                result.Add(UserGroupResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            UserGroupDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.UserGroup> entity = new List<Data.Entity.UserGroup>();
            foreach (var id in idList)
            {
                entity.Add(UserGroupDao.Find(id));
            }
            foreach (var id in idList)
            {
                UserGroupDao.Delete(id);
            }
        }

        public UserGroupResult Find(long id)
        {
            Data.Entity.UserGroup entity = UserGroupDao.Find(id);
            UserGroupResult result = UserGroupResultConverter.Convert(entity);
            return result;
        }

        public List<UserGroupResult> Find()
        {
            List<Data.Entity.UserGroup> entity = UserGroupDao.Find();
            List<UserGroupResult> results = new List<UserGroupResult>();
            foreach (var item in entity)
            {
                results.Add(UserGroupResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserGroupParam param)
        {
            Data.Entity.UserGroup oldEntity = UserGroupDao.Find(id);
            Data.Entity.UserGroup newEntity = UserGroupParamConverter.Convert(param, null);
            UserGroupDao.Update(newEntity);
        }

        public void Update(List<UserGroupParam> param)
        {
            List<Data.Entity.UserGroup> entity = new List<Data.Entity.UserGroup>();
            foreach (var item in param)
            {
                Data.Entity.UserGroup oldEntity = UserGroupDao.Find(item.Id);
                Data.Entity.UserGroup newEntity = UserGroupParamConverter.Convert(item, null);
                UserGroupDao.Update(newEntity);
            }
        }
    }
}
