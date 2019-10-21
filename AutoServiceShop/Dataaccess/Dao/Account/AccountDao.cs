using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountDao : IAccountDao
    {
        public void Delete(long id)
        {
            Data.Entity.Account entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Account entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Account> Find()
        {
            throw new NotImplementedException();
        }

        public Data.Entity.Account Find(long id)
        {
            throw new NotImplementedException();
        }

        public Data.Entity.Account Save(Data.Entity.Account entity)
        {
            return entity;
        }

        public List<Data.Entity.Account> Save(List<Data.Entity.Account> entity)
        {
            return entity;
        }

        public Data.Entity.Account Update(Data.Entity.Account entity)
        {
            throw new NotImplementedException();
        }

        public List<Data.Entity.Account> Update(List<Data.Entity.Account> entity)
        {
            throw new NotImplementedException();
        }
    }
}
