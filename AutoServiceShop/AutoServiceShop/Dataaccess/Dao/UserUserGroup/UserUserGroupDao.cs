using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.UserUserGroup
{
    class UserUserGroupDao : IUserUserGroupDao
    {
        public void Delete(long id)
        {
            Data.Entity.UserUserGroup entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.UserUserGroup entity)
        {
            UserUserGroupStorage.UserUserGroupList.Remove(entity);
            UserUserGroupStorage.UserUserGroupDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.UserUserGroup> Find()
        {
            return UserUserGroupStorage.UserUserGroupList;
        }

        public Data.Entity.UserUserGroup Find(long id)
        {
            return UserUserGroupStorage.UserUserGroupList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.UserUserGroup> FindByField(string field, string value)
        {
            return UserUserGroupStorage.UserUserGroupList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.UserUserGroup Save(Data.Entity.UserUserGroup entity)
        {

            UserUserGroupStorage.UserUserGroupList.Add(entity);
            UserUserGroupStorage.UserUserGroupDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.UserUserGroup> Save(List<Data.Entity.UserUserGroup> entity)
        {
            entity.ForEach(x => UserUserGroupStorage.UserUserGroupList.Add(x));

            entity.ForEach(x => UserUserGroupStorage.UserUserGroupDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.UserUserGroup Update(Data.Entity.UserUserGroup entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.UserUserGroup> Update(List<Data.Entity.UserUserGroup> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
