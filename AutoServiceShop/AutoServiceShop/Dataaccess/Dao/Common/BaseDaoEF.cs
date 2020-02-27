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
        private readonly AutoServiceShopContext _context;

        public BaseDaoEF(AutoServiceShopContext context)
        {
            _context = context;
        }

        public void Delete(TId id)
        {
            var entity = _context.Set<TEntity>().Find(id);

            entity.Active = 0;

            _context.Entry(entity).CurrentValues.SetValues(entity);

            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(List<TId> idList)
        {

            idList.ForEach(x => _context.Set<TEntity>()
            .Remove(_context.Set<TEntity>()
            .Find(x)));

            _context.SaveChanges();
        }

        public void Erase(TId id)
        {
            var entity = _context.Set<TEntity>().Find(id);

            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public List<TEntity> Find()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity Find(TId id)
        {
            TEntity entity = _context.Set<TEntity>().Find(id);

            return entity;
        }

        public List<TEntity> FindByField(string field, string value)
        {

            List<TEntity> entity = _context.Set<TEntity>().ToList();

            return entity.Where
                (x => x.GetType().GetProperty(field).GetValue(x, null).ToString()
                .Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public TEntity Save(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;

            _context.Set<TEntity>().Add(entity);

            _context.SaveChanges();

            return entity;
        }

        public List<TEntity> Save(List<TEntity> entity)
        {

            entity.ForEach(x => _context.Set<TEntity>().Add(x));

            _context.SaveChanges();

            return entity;
        }

        public TEntity Update(TEntity entity)
        {

            _context.Entry(entity).CurrentValues.SetValues(entity);

            _context.SaveChanges();

            return entity;
        }

        public List<TEntity> Update(List<TEntity> entity)
        {

            entity.ForEach(x => _context.Entry(x).CurrentValues.SetValues(x));

            _context.SaveChanges();

            return entity;
        }
    }
}
