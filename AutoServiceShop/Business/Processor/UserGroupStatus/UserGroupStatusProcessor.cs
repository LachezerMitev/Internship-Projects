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
        IUserGroupStatusDao UserGroupStatusDao = new UserGroupStatusDao();

        IUserGroupStatusParamConverter UserGroupStatusParamConverter = new UserGroupStatusParamConverter();
        IUserGroupStatusResultConverter UserGroupStatusResultConverter = new UserGroupStatusResultConverter();

        public UserGroupStatusResult Create(UserGroupStatusParam param)
        {
            Data.Entity.UserGroupStatus entity = UserGroupStatusParamConverter.Convert(param);
            UserGroupStatusDao.Save(entity);

            return UserGroupStatusResultConverter.Convert(entity);
        }

        public List<UserGroupStatusResult> Create(List<UserGroupStatusParam> param)
        {
            List<Data.Entity.UserGroupStatus> entities = new List<Data.Entity.UserGroupStatus>();
            foreach (var item in param)
            {
                entities.Add(UserGroupStatusParamConverter.Convert(item));
            }
            UserGroupStatusDao.Save(entities);
            List<UserGroupStatusResult> result = new List<UserGroupStatusResult>();
            foreach (var item in entities)
            {
                result.Add(UserGroupStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            UserGroupStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.UserGroupStatus> entity = new List<Data.Entity.UserGroupStatus>();
            foreach (var id in idList)
            {
                entity.Add(UserGroupStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                UserGroupStatusDao.Delete(id);
            }
        }

        public UserGroupStatusResult Find(long id)
        {
            Data.Entity.UserGroupStatus entity = UserGroupStatusDao.Find(id);
            UserGroupStatusResult result = UserGroupStatusResultConverter.Convert(entity);
            return result;
        }

        public List<UserGroupStatusResult> Find()
        {
            List<Data.Entity.UserGroupStatus> accounts = UserGroupStatusDao.Find();
            List<UserGroupStatusResult> results = new List<UserGroupStatusResult>();
            foreach (var item in accounts)
            {
                results.Add(UserGroupStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserGroupStatusParam param)
        {
            Data.Entity.UserGroupStatus oldEntity = UserGroupStatusDao.Find(id);
            Data.Entity.UserGroupStatus newEntity = UserGroupStatusParamConverter.Convert(param);
            UserGroupStatusDao.Update(newEntity);
        }

        public void Update(List<UserGroupStatusParam> param)
        {
            List<Data.Entity.UserGroupStatus> entity = new List<Data.Entity.UserGroupStatus>();
            foreach (var item in param)
            {
                Data.Entity.UserGroupStatus oldEntity = UserGroupStatusDao.Find(item.Id);
                Data.Entity.UserGroupStatus newEntity = UserGroupStatusParamConverter.Convert(item);
                UserGroupStatusDao.Update(newEntity);
            }
        }
    }
}
