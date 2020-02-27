using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    interface IModelDao
    {
<<<<<<< Updated upstream
        Data.Entity.Model Save(Data.Entity.Model entity);
        List<Data.Entity.Model> Save(List<Data.Entity.Model> entity);

        Data.Entity.Model Update(Data.Entity.Model entity);
        List<Data.Entity.Model> Update(List<Data.Entity.Model> entity);

        void Delete(long id);
        void Delete(Data.Entity.Model entity);
        void Delete(List<long> idList);

        List<Data.Entity.Model> Find();
        Data.Entity.Model Find(long id);
=======
>>>>>>> Stashed changes
    }
}
