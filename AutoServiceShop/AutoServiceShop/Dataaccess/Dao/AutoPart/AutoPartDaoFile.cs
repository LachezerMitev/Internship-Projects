using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.AutoPart
{
    class AutoPartDaoFile : BaseDaoFile<Data.Entity.AutoPart, long, AutoPartStorage>, IAutoPartDao
    {
        //public void Delete(long id)
        //{
        //    var context = new AutoServiceShopContext();

        //    var autoPart = context.AutoParts.Where(x => x.Id == id).First();

        //    context.AutoParts.Remove(autoPart);
        //    context.SaveChanges();
        //}

        //public void Delete(Data.Entity.AutoPart entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.AutoParts.Remove(entity);
        //    context.SaveChanges();
        //}

        //public void Delete(List<long> idList)
        //{
        //    idList.ForEach(x => Delete(x));
        //}

        //public List<Data.Entity.AutoPart> Find()
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.AutoParts.ToList();
        //}

        //public Data.Entity.AutoPart Find(long id)
        //{
        //    var context = new AutoServiceShopContext();
        //    return context.AutoParts
        //        .Where(x => x.Id.Equals(id))
        //        .Single();
        //}

        //public List<Data.Entity.AutoPart> FindByField(string field, string value)
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.AutoParts.Where
        //        (entity => entity.GetType().GetProperty(field).GetValue(entity, null).ToString().Equals(value)).ToList();
        //}

        //public Data.Entity.AutoPart Save(Data.Entity.AutoPart entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.AutoParts.Add(entity);
        //    context.SaveChanges();

        //    return entity;
        //}

        //public List<Data.Entity.AutoPart> Save(List<Data.Entity.AutoPart> entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    entity.ForEach(x => context.AutoParts.Add(x));

        //    context.SaveChanges();

        //    return entity;
        //}

        //public Data.Entity.AutoPart Update(Data.Entity.AutoPart entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

        //    context.SaveChanges();

        //    //Delete(entity.Id);
        //    //Save(entity);
        //    return entity;
        //}

        //public List<Data.Entity.AutoPart> Update(List<Data.Entity.AutoPart> entity)
        //{
        //    entity.ForEach(x => Update(x));
        //    return entity;
        //}
    }
}
