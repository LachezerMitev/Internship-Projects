using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Customer
{
    class CustomerDao : ICustomerDao
    {
        public void Delete(long id)
        {
            Data.Entity.Customer entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Customer entity)
        {
            CustomerStorage.CustomerList.Remove(entity);
            CustomerStorage.CustomerDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Customer> Find()
        {
            return CustomerStorage.CustomerList;
        }

        public Data.Entity.Customer Find(long id)
        {
            return CustomerStorage.CustomerList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.Customer Save(Data.Entity.Customer entity)
        {

            CustomerStorage.CustomerList.Add(entity);
            CustomerStorage.CustomerDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Customer> Save(List<Data.Entity.Customer> entity)
        {
            entity.ForEach(x => CustomerStorage.CustomerList.Add(x));

            entity.ForEach(x => CustomerStorage.CustomerDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Customer Update(Data.Entity.Customer entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.Customer> Update(List<Data.Entity.Customer> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
