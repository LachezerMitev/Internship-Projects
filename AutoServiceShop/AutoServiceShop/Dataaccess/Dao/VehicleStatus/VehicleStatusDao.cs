using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.VehicleStatus
{
    class VehicleStatusDao : IVehicleStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.VehicleStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.VehicleStatus entity)
        {
            VehicleStatusStorage.VehicleStatusList.Remove(entity);
            VehicleStatusStorage.VehicleStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.VehicleStatus> Find()
        {
            return VehicleStatusStorage.VehicleStatusList;
        }

        public Data.Entity.VehicleStatus Find(long id)
        {
            return VehicleStatusStorage.VehicleStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.VehicleStatus> FindByField(string field, string value)
        {
            return VehicleStatusStorage.VehicleStatusList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.VehicleStatus Save(Data.Entity.VehicleStatus entity)
        {

            VehicleStatusStorage.VehicleStatusList.Add(entity);
            VehicleStatusStorage.VehicleStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.VehicleStatus> Save(List<Data.Entity.VehicleStatus> entity)
        {
            entity.ForEach(x => VehicleStatusStorage.VehicleStatusList.Add(x));

            entity.ForEach(x => VehicleStatusStorage.VehicleStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.VehicleStatus Update(Data.Entity.VehicleStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.VehicleStatus> Update(List<Data.Entity.VehicleStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
