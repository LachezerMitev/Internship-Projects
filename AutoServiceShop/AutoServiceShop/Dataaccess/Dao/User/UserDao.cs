using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.User
{
    class UserDao : IUserDao
    {
        public void Delete(long id)
        {
            Data.Entity.User entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.User entity)
        {
            UserStorage.UserList.Remove(entity);
            UserStorage.UserDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.User> Find()
        {
            return UserStorage.UserList;
        }

        public Data.Entity.User Find(long id)
        {
            return UserStorage.UserList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.User> FindByField(string field, string value)
        {
            return UserStorage.UserList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.User Save(Data.Entity.User entity)
        {

            UserStorage.UserList.Add(entity);
            UserStorage.UserDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.User> Save(List<Data.Entity.User> entity)
        {
            entity.ForEach(x => UserStorage.UserList.Add(x));

            entity.ForEach(x => UserStorage.UserDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.User Update(Data.Entity.User entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.User> Update(List<Data.Entity.User> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
