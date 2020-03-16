using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.Common;

namespace AutoServiceShop.Business.Processor.UserGroupStatus
{
    public class UserGroupStatusProcessor
        : BaseProcessor<IUserGroupStatusParamConverter, IUserGroupStatusResultConverter, UserGroupStatusParam, UserGroupStatusResult, IUserGroupStatusDao, long, Data.Entity.UserGroupStatus>, IUserGroupStatusProcessor
    {
<<<<<<< Updated upstream
        IUserGroupStatusDao UserGroupStatusDao = new UserGroupStatusDao();

        IUserGroupStatusParamConverter UserGroupStatusParamConverter = new UserGroupStatusParamConverter();
        IUserGroupStatusResultConverter UserGroupStatusResultConverter = new UserGroupStatusResultConverter();

        public UserGroupStatusResult Create(UserGroupStatusParam param)
        {
            Data.Entity.UserGroupStatus entity = UserGroupStatusParamConverter.Convert(param, null);
            UserGroupStatusDao.Save(entity);

            return UserGroupStatusResultConverter.Convert(entity);
        }

        public List<UserGroupStatusResult> Create(List<UserGroupStatusParam> param)
        {
            List<Data.Entity.UserGroupStatus> entities = new List<Data.Entity.UserGroupStatus>();
            foreach (var item in param)
            {
                entities.Add(UserGroupStatusParamConverter.Convert(item, null));
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
            List<Data.Entity.UserGroupStatus> entity = UserGroupStatusDao.Find();
            List<UserGroupStatusResult> results = new List<UserGroupStatusResult>();
            foreach (var item in entity)
            {
                results.Add(UserGroupStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, UserGroupStatusParam param)
        {
            Data.Entity.UserGroupStatus oldEntity = UserGroupStatusDao.Find(id);
            Data.Entity.UserGroupStatus newEntity = UserGroupStatusParamConverter.Convert(param, null);
            UserGroupStatusDao.Update(newEntity);
        }

        public void Update(List<UserGroupStatusParam> param)
=======
        public UserGroupStatusProcessor(IUserGroupStatusDao dao, IUserGroupStatusParamConverter paramConverter, IUserGroupStatusResultConverter resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
        }
    }
}
