using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.AccountStatus
{
    class AccountStatusDaoFile 
        : BaseDaoFile<Data.Entity.AccountStatus, long, AccountStatusStorage>, IAccountStatusDao
    {
        //public void Delete(long id)
        //{
        //    var context = new AutoServiceShopContext();

        //    var user = context.AccountStatuses.Where(x => x.Id == id).First();

        //    context.AccountStatuses.Remove(user);
        //    context.SaveChanges();
        //}

        //public void Delete(Data.Entity.AccountStatus entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.AccountStatuses.Remove(entity);
        //    context.SaveChanges();
        //}

        //public void Delete(List<long> idList)
        //{
        //    idList.ForEach(x => Delete(x));
        //}

        //public List<Data.Entity.AccountStatus> Find()
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.AccountStatuses.ToList();
        //}

        //public Data.Entity.AccountStatus Find(long id)
        //{
        //    var context = new AutoServiceShopContext();
        //    return context.AccountStatuses
        //        .Where(x => x.Id.Equals(id))
        //        .Single();
        //}

        //public List<Data.Entity.AccountStatus> FindByField(string field, string value)
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.AccountStatuses.Where
        //        (entity => entity.GetType().GetProperty(field).GetValue(entity, null).ToString().Equals(value)).ToList();
        //}

        //public Data.Entity.AccountStatus Save(Data.Entity.AccountStatus entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.AccountStatuses.Add(entity);
        //    context.SaveChanges();

        //    return entity;
        //}

        //public List<Data.Entity.AccountStatus> Save(List<Data.Entity.AccountStatus> entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    entity.ForEach(x => context.AccountStatuses.Add(x));

        //    context.SaveChanges();

        //    return entity;
        //}

        //public Data.Entity.AccountStatus Update(Data.Entity.AccountStatus entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

        //    context.SaveChanges();

        //    //Delete(entity.Id);
        //    //Save(entity);
        //    return entity;
        //}

        //public List<Data.Entity.AccountStatus> Update(List<Data.Entity.AccountStatus> entity)
        //{
        //    entity.ForEach(x => Update(x));
        //    return entity;
        //}
    }
}
