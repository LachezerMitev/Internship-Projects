using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    class ModelDao : IModelDao
    {
        public void Delete(long id)
        {
            Data.Entity.Model entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Model entity)
        {
            ModelStorage.ModelList.Remove(entity);
            ModelStorage.ModelDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Model> Find()
        {
            return ModelStorage.ModelList;
        }

        public Data.Entity.Model Find(long id)
        {
            return ModelStorage.ModelList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.Model Save(Data.Entity.Model entity)
        {

            ModelStorage.ModelList.Add(entity);
            ModelStorage.ModelDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Model> Save(List<Data.Entity.Model> entity)
        {
            entity.ForEach(x => ModelStorage.ModelList.Add(x));

            entity.ForEach(x => ModelStorage.ModelDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Model Update(Data.Entity.Model entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.Model> Update(List<Data.Entity.Model> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
