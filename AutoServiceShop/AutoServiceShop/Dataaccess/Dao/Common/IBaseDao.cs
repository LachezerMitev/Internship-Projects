using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Common
{
    public interface IBaseDao<TEntity, TId>
    {
        TEntity Save(TEntity entity);
        List<TEntity> Save(List<TEntity> entity);

        TEntity Update(TEntity entity);
        List<TEntity> Update(List<TEntity> entity);

        void Delete(TId id);
        void Delete(TEntity entity);
        void Delete(List<TId> idList);

        List<TEntity> Find();
        TEntity Find(TId id);
        List<TEntity> FindByField(string field, string value);
    }
}
