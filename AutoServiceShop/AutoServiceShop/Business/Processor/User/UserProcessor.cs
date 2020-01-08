using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.Common;

namespace AutoServiceShop.Business.Processor.User
{
    public class UserProcessor : 
        BaseProcessor<IUserParamConverter, IUserResultConverter, UserParam, UserResult, IUserDao, long, Data.Entity.User>, IUserProcessor
    {
<<<<<<< Updated upstream
        IUserDao UserDao = new UserDao();

        IUserParamConverter UserParamConverter = new UserParamConverter();
        IUserResultConverter UserResultConverter = new UserResultConverter();

        public UserResult Create(UserParam param)
        {
            Data.Entity.User entity = UserParamConverter.Convert(param, null);
            UserDao.Save(entity);

            return UserResultConverter.Convert(entity);
        }

        public List<UserResult> Create(List<UserParam> param)
        {
            List<Data.Entity.User> entities = new List<Data.Entity.User>();
            foreach (var item in param)
            {
                entities.Add(UserParamConverter.Convert(item, null));
            }
            UserDao.Save(entities);
            List<UserResult> result = new List<UserResult>();
            foreach (var item in entities)
            {
                result.Add(UserResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            UserDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.User> entity = new List<Data.Entity.User>();
            foreach (var id in idList)
            {
                entity.Add(UserDao.Find(id));
            }
            foreach (var id in idList)
            {
                UserDao.Delete(id);
            }
        }

        public UserResult Find(long id)
        {
            Data.Entity.User entity = UserDao.Find(id);
            UserResult result = UserResultConverter.Convert(entity);
            return result;
        }

        public List<UserResult> Find()
        {
            List<Data.Entity.User> entity = UserDao.Find();
            List<UserResult> results = new List<UserResult>();
            foreach (var item in entity)
            {
                results.Add(UserResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserParam param)
        {
            Data.Entity.User oldEntity = UserDao.Find(id);
            Data.Entity.User newEntity = UserParamConverter.Convert(param, null);
            UserDao.Update(newEntity);
        }

        public void Update(List<UserParam> param)
        {
            List<Data.Entity.User> entity = new List<Data.Entity.User>();
            foreach (var item in param)
            {
                Data.Entity.User oldEntity = UserDao.Find(item.Id);
                Data.Entity.User newEntity = UserParamConverter.Convert(item, null);
                UserDao.Update(newEntity);
            }
        }
=======
>>>>>>> Stashed changes
    }
}
