using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.VehicleMakeModel
{
    class VehicleMakeModelDao : IVehicleMakeModelDao
    {
        public void Delete(long id)
        {
            Data.Entity.VehicleMakeModel entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.VehicleMakeModel entity)
        {
            VehicleMakeModelStorage.VehicleMakeModelList.Remove(entity);
            VehicleMakeModelStorage.VehicleMakeModelDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.VehicleMakeModel> Find()
        {
            return VehicleMakeModelStorage.VehicleMakeModelList;
        }

        public Data.Entity.VehicleMakeModel Find(long id)
        {
            return VehicleMakeModelStorage.VehicleMakeModelList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.VehicleMakeModel Save(Data.Entity.VehicleMakeModel entity)
        {

            VehicleMakeModelStorage.VehicleMakeModelList.Add(entity);
            VehicleMakeModelStorage.VehicleMakeModelDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.VehicleMakeModel> Save(List<Data.Entity.VehicleMakeModel> entity)
        {
            entity.ForEach(x => VehicleMakeModelStorage.VehicleMakeModelList.Add(x));

            entity.ForEach(x => VehicleMakeModelStorage.VehicleMakeModelDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.VehicleMakeModel Update(Data.Entity.VehicleMakeModel entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.VehicleMakeModel> Update(List<Data.Entity.VehicleMakeModel> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
