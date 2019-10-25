using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.UserGroup
{
    class UserGroupDao : IUserGroupDao
    {
        public void Delete(long id)
        {
            Data.Entity.UserGroup entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.UserGroup entity)
        {
            UserGroupStorage.UserGroupList.Remove(entity);
            UserGroupStorage.UserGroupDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.UserGroup> Find()
        {
            return UserGroupStorage.UserGroupList;
        }

        public Data.Entity.UserGroup Find(long id)
        {
            return UserGroupStorage.UserGroupList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.UserGroup Save(Data.Entity.UserGroup entity)
        {

            UserGroupStorage.UserGroupList.Add(entity);
            UserGroupStorage.UserGroupDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.UserGroup> Save(List<Data.Entity.UserGroup> entity)
        {
            entity.ForEach(x => UserGroupStorage.UserGroupList.Add(x));

            entity.ForEach(x => UserGroupStorage.UserGroupDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.UserGroup Update(Data.Entity.UserGroup entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.UserGroup> Update(List<Data.Entity.UserGroup> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
