using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.AutoPart
{
    class AutoPartDao : IAutoPartDao
    {
        public void Delete(long id)
        {
            Data.Entity.AutoPart entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.AutoPart entity)
        {
            AutoPartStorage.AutoPartList.Remove(entity);
            AutoPartStorage.AutoPartDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.AutoPart> Find()
        {
            return AutoPartStorage.AutoPartList;
        }

        public Data.Entity.AutoPart Find(long id)
        {
            return AutoPartStorage.AutoPartList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.AutoPart> FindByField(string field, string value)
        {
            return AutoPartStorage.AutoPartList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.AutoPart Save(Data.Entity.AutoPart entity)
        {
            AutoPartStorage.AutoPartList.Add(entity);
            AutoPartStorage.AutoPartDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.AutoPart> Save(List<Data.Entity.AutoPart> entity)
        {
            entity.ForEach(x => AutoPartStorage.AutoPartList.Add(x));

            entity.ForEach(x => AutoPartStorage.AutoPartDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.AutoPart Update(Data.Entity.AutoPart entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.AutoPart> Update(List<Data.Entity.AutoPart> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
