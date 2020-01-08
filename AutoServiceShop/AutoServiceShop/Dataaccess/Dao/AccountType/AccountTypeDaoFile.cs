using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AccountType
{
    class AccountTypeDaoFile : BaseDaoFile<Data.Entity.AccountType, long, AccountTypeStorage>, IAccountTypeDao
    {
        //public void Delete(long id)
        //{
        //    var context = new AutoServiceShopContext();

        //    var user = context.AccountTypes.Where(x => x.Id == id).First();

        //    context.AccountTypes.Remove(user);
        //    context.SaveChanges();
        //}

        //public void Delete(Data.Entity.AccountType entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.AccountTypes.Remove(entity);
        //    context.SaveChanges();
        //}

        //public void Delete(List<long> idList)
        //{
        //    idList.ForEach(x => Delete(x));
        //}

        //public List<Data.Entity.AccountType> Find()
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.AccountTypes.ToList();
        //}

        //public Data.Entity.AccountType Find(long id)
        //{
        //    var context = new AutoServiceShopContext();
        //    return context.AccountTypes
        //        .Where(x => x.Id.Equals(id))
        //        .Single();
        //}

        //public List<Data.Entity.AccountType> FindByField(string field, string value)
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.AccountTypes.Where
        //        (entity => entity.GetType().GetProperty(field).GetValue(entity, null).ToString().Equals(value)).ToList();
        //}

        //public Data.Entity.AccountType Save(Data.Entity.AccountType entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.AccountTypes.Add(entity);
        //    context.SaveChanges();

        //    return entity;
        //}

        //public List<Data.Entity.AccountType> Save(List<Data.Entity.AccountType> entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    entity.ForEach(x => context.AccountTypes.Add(x));

        //    context.SaveChanges();

        //    return entity;
        //}

        //public Data.Entity.AccountType Update(Data.Entity.AccountType entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

        //    context.SaveChanges();

        //    //Delete(entity.Id);
        //    //Save(entity);
        //    return entity;
        //}

        //public List<Data.Entity.AccountType> Update(List<Data.Entity.AccountType> entity)
        //{
        //    entity.ForEach(x => Update(x));
        //    return entity;
        //}
    }
}
