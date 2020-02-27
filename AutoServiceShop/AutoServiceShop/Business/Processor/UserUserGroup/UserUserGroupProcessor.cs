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
<<<<<<< Updated upstream
        IUserUserGroupDao UserUserGroupDao = new UserUserGroupDao();

        IUserUserGroupParamConverter UserUserGroupParamConverter = new UserUserGroupParamConverter();
        IUserUserGroupResultConverter UserUserGroupResultConverter = new UserUserGroupResultConverter();

        public UserUserGroupResult Create(UserUserGroupParam param)
        {
            Data.Entity.UserUserGroup entity = UserUserGroupParamConverter.Convert(param, null);
            UserUserGroupDao.Save(entity);

            return UserUserGroupResultConverter.Convert(entity);
        }

        public List<UserUserGroupResult> Create(List<UserUserGroupParam> param)
        {
            List<Data.Entity.UserUserGroup> entities = new List<Data.Entity.UserUserGroup>();
            foreach (var item in param)
            {
                entities.Add(UserUserGroupParamConverter.Convert(item, null));
            }
            UserUserGroupDao.Save(entities);
            List<UserUserGroupResult> result = new List<UserUserGroupResult>();
            foreach (var item in entities)
            {
                result.Add(UserUserGroupResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            UserUserGroupDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.UserUserGroup> entity = new List<Data.Entity.UserUserGroup>();
            foreach (var id in idList)
            {
                entity.Add(UserUserGroupDao.Find(id));
            }
            foreach (var id in idList)
            {
                UserUserGroupDao.Delete(id);
            }
        }

        public UserUserGroupResult Find(long id)
        {
            Data.Entity.UserUserGroup entity = UserUserGroupDao.Find(id);
            UserUserGroupResult result = UserUserGroupResultConverter.Convert(entity);
            return result;
        }

        public List<UserUserGroupResult> Find()
        {
            List<Data.Entity.UserUserGroup> entity = UserUserGroupDao.Find();
            List<UserUserGroupResult> results = new List<UserUserGroupResult>();
            foreach (var item in entity)
            {
                results.Add(UserUserGroupResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserUserGroupParam param)
        {
            Data.Entity.UserUserGroup oldEntity = UserUserGroupDao.Find(id);
            Data.Entity.UserUserGroup newEntity = UserUserGroupParamConverter.Convert(param, null);
            UserUserGroupDao.Update(newEntity);
        }

        public void Update(List<UserUserGroupParam> param)
=======
        public UserUserGroupProcessor(IUserUserGroupDao dao, IUserUserGroupParamConverter paramConverter, IUserUserGroupResultConverter resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
            List<Data.Entity.UserUserGroup> entity = new List<Data.Entity.UserUserGroup>();
            foreach (var item in param)
            {
                Data.Entity.UserUserGroup oldEntity = UserUserGroupDao.Find(item.Id);
                Data.Entity.UserUserGroup newEntity = UserUserGroupParamConverter.Convert(item, null);
                UserUserGroupDao.Update(newEntity);
            }
        }
    }
}
