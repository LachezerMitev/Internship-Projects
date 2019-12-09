using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.EmployeeStatus
{
    class EmployeeStatusDao : IEmployeeStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.EmployeeStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.EmployeeStatus entity)
        {
            EmployeeStatusStorage.EmployeeStatusList.Remove(entity);
            EmployeeStatusStorage.EmployeeStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.EmployeeStatus> Find()
        {
            return EmployeeStatusStorage.EmployeeStatusList;
        }

        public Data.Entity.EmployeeStatus Find(long id)
        {
            return EmployeeStatusStorage.EmployeeStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.EmployeeStatus> FindByField(string field, string value)
        {
            return EmployeeStatusStorage.EmployeeStatusList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.EmployeeStatus Save(Data.Entity.EmployeeStatus entity)
        {

            EmployeeStatusStorage.EmployeeStatusList.Add(entity);
            EmployeeStatusStorage.EmployeeStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.EmployeeStatus> Save(List<Data.Entity.EmployeeStatus> entity)
        {
            entity.ForEach(x => EmployeeStatusStorage.EmployeeStatusList.Add(x));

            entity.ForEach(x => EmployeeStatusStorage.EmployeeStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.EmployeeStatus Update(Data.Entity.EmployeeStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.EmployeeStatus> Update(List<Data.Entity.EmployeeStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
