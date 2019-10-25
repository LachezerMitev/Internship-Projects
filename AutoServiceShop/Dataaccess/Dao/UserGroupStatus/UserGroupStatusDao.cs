using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.UserGroupStatus
{
    class UserGroupStatusDao : IUserGroupStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.UserGroupStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.UserGroupStatus entity)
        {
            UserGroupStatusStorage.UserGroupStatusList.Remove(entity);
            UserGroupStatusStorage.UserGroupStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.UserGroupStatus> Find()
        {
            return UserGroupStatusStorage.UserGroupStatusList;
        }

        public Data.Entity.UserGroupStatus Find(long id)
        {
            return UserGroupStatusStorage.UserGroupStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.UserGroupStatus Save(Data.Entity.UserGroupStatus entity)
        {

            UserGroupStatusStorage.UserGroupStatusList.Add(entity);
            UserGroupStatusStorage.UserGroupStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.UserGroupStatus> Save(List<Data.Entity.UserGroupStatus> entity)
        {
            entity.ForEach(x => UserGroupStatusStorage.UserGroupStatusList.Add(x));

            entity.ForEach(x => UserGroupStatusStorage.UserGroupStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.UserGroupStatus Update(Data.Entity.UserGroupStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.UserGroupStatus> Update(List<Data.Entity.UserGroupStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
