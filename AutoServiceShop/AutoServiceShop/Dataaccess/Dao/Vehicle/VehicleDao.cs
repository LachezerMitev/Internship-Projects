using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Vehicle
{
    class VehicleDao : IVehicleDao
    {
        public void Delete(long id)
        {
            Data.Entity.Vehicle entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Vehicle entity)
        {
            VehicleStorage.VehicleList.Remove(entity);
            VehicleStorage.VehicleDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Vehicle> Find()
        {
            return VehicleStorage.VehicleList;
        }

        public Data.Entity.Vehicle Find(long id)
        {
            return VehicleStorage.VehicleList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.Vehicle> FindByField(string field, string value)
        {
            return VehicleStorage.VehicleList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.Vehicle Save(Data.Entity.Vehicle entity)
        {

            VehicleStorage.VehicleList.Add(entity);
            VehicleStorage.VehicleDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Vehicle> Save(List<Data.Entity.Vehicle> entity)
        {
            entity.ForEach(x => VehicleStorage.VehicleList.Add(x));

            entity.ForEach(x => VehicleStorage.VehicleDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Vehicle Update(Data.Entity.Vehicle entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.Vehicle> Update(List<Data.Entity.Vehicle> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
