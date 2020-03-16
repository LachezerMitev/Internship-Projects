using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPart
{
    public interface IAutoPartDao
        : IBaseDao<Data.Entity.AutoPart, long>
    {
<<<<<<< Updated upstream
        Data.Entity.AutoPart Save(Data.Entity.AutoPart entity);
        List<Data.Entity.AutoPart> Save(List<Data.Entity.AutoPart> entity);

        Data.Entity.AutoPart Update(Data.Entity.AutoPart entity);
        List<Data.Entity.AutoPart> Update(List<Data.Entity.AutoPart> entity);

        void Delete(long id);
        void Delete(Data.Entity.AutoPart entity);
        void Delete(List<long> idList);

        List<Data.Entity.AutoPart> Find();
        Data.Entity.AutoPart Find(long id);
=======
>>>>>>> Stashed changes
    }
}
