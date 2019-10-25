using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Make
{
    class MakeDao : IMakeDao
    {
        public void Delete(long id)
        {
            Data.Entity.Make entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Make entity)
        {
            MakeStorage.MakeList.Remove(entity);
            MakeStorage.MakeDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Make> Find()
        {
            return MakeStorage.MakeList;
        }

        public Data.Entity.Make Find(long id)
        {
            return MakeStorage.MakeList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.Make Save(Data.Entity.Make entity)
        {

            MakeStorage.MakeList.Add(entity);
            MakeStorage.MakeDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Make> Save(List<Data.Entity.Make> entity)
        {
            entity.ForEach(x => MakeStorage.MakeList.Add(x));

            entity.ForEach(x => MakeStorage.MakeDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Make Update(Data.Entity.Make entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.Make> Update(List<Data.Entity.Make> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
