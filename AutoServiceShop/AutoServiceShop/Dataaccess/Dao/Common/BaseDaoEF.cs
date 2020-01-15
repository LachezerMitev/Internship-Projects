using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Common
{
    public class BaseDaoEF<TEntity, TId> : IBaseDao<TEntity, TId>
        where TEntity : Data.Entity.Persistent
    {
        public void Delete(TId id)
        {
            var context = new AutoServiceShopContext();

            var entity = context.Set<TEntity>().Find(id);

            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            var context = new AutoServiceShopContext();

            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public void Delete(List<TId> idList)
        {
            var context = new AutoServiceShopContext();

            idList.ForEach(x => context.Set<TEntity>()
            .Remove(context.Set<TEntity>()
            .Find(x)));

            context.SaveChanges();
        }

        public List<TEntity> Find()
        {
            var context = new AutoServiceShopContext();

            return context.Set<TEntity>().ToList();
        }

        public TEntity Find(TId id)
        {
            var context = new AutoServiceShopContext();

            TEntity entity = context.Set<TEntity>().Find(id);

            return entity;
        }

        public List<TEntity> FindByField(string field, string value)
        {
            var context = new AutoServiceShopContext();

            List<TEntity> entity = context.Set<TEntity>().ToList();

            return entity.Where
                (x => x.GetType().GetProperty(field).GetValue(x, null).ToString()
                .Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public TEntity Save(TEntity entity)
        {
            var context = new AutoServiceShopContext();

            context.Entry(entity).State = EntityState.Added;

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();

            return entity;
        }

        public List<TEntity> Save(List<TEntity> entity)
        {
            var context = new AutoServiceShopContext();

            entity.ForEach(x => context.Set<TEntity>().Add(x));

            context.SaveChanges();

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            var context = new AutoServiceShopContext();

            context.Entry(entity).CurrentValues.SetValues(entity);

            context.SaveChanges();

            return entity;
        }

        public List<TEntity> Update(List<TEntity> entity)
        {
            var context = new AutoServiceShopContext();

            entity.ForEach(x => context.Entry(x).CurrentValues.SetValues(x));

            context.SaveChanges();

            return entity;
        }
    }
}
