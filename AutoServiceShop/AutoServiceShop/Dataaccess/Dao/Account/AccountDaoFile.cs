using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountDaoFile : BaseDaoFile<Data.Entity.Account, long, AccountStorage>, IAccountDao
    {
        //public void Delete(long id)
        //{
        //    var context = new AutoServiceShopContext();

        //    var account = context.Accounts.Where(x => x.Id == id).First();

        //    context.Accounts.Remove(account);
        //    context.SaveChanges();
        //}

        //public void Delete(Data.Entity.Account entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.Accounts.Remove(entity);
        //    context.SaveChanges();
        //}

        //public void Delete(List<long> idList)
        //{
        //    idList.ForEach(x => Delete(x));
        //}

        //public List<Data.Entity.Account> Find()
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.Accounts.ToList();
        //}

        //public Data.Entity.Account Find(long id)
        //{
        //    var context = new AutoServiceShopContext();
        //    return context.Accounts
        //        .Where(x => x.Id.Equals(id))
        //        .Single();
        //}

        //public List<Data.Entity.Account> FindByField(string field, string value)
        //{
        //    var context = new AutoServiceShopContext();

        //    return context.Accounts.Where
        //        (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        //}

        //public Data.Entity.Account Save(Data.Entity.Account entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.Accounts.Add(entity);
        //    context.SaveChanges();

        //    return entity;
        //}

        //public List<Data.Entity.Account> Save(List<Data.Entity.Account> entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    entity.ForEach(x => context.Accounts.Add(x));

        //    context.SaveChanges();

        //    return entity;
        //}

        //public Data.Entity.Account Update(Data.Entity.Account entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

        //    context.SaveChanges();

        //    //Delete(entity.Id);
        //    //Save(entity);
        //    return entity;
        //}

        //public List<Data.Entity.Account> Update(List<Data.Entity.Account> entity)
        //{
        //    var context = new AutoServiceShopContext();

        //    entity.ForEach(x => context.Entry(x).State = System.Data.Entity.EntityState.Modified);

        //    context.SaveChanges();

        //    return entity;
        //}
    }
}
