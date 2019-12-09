using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Employee
{
    class EmployeeDao : IEmployeeDao
    {
        public void Delete(long id)
        {
            Data.Entity.Employee entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Employee entity)
        {
            EmployeeStorage.EmployeeList.Remove(entity);
            EmployeeStorage.EmployeeDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Employee> Find()
        {
            return EmployeeStorage.EmployeeList;
        }

        public Data.Entity.Employee Find(long id)
        {
            return EmployeeStorage.EmployeeList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.Employee> FindByField(string field, string value)
        {
            return EmployeeStorage.EmployeeList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.Employee Save(Data.Entity.Employee entity)
        {

            EmployeeStorage.EmployeeList.Add(entity);
            EmployeeStorage.EmployeeDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Employee> Save(List<Data.Entity.Employee> entity)
        {
            entity.ForEach(x => EmployeeStorage.EmployeeList.Add(x));

            entity.ForEach(x => EmployeeStorage.EmployeeDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Employee Update(Data.Entity.Employee entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.Employee> Update(List<Data.Entity.Employee> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
