using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractStatus
{
    public interface IContractStatusDao : IBaseDao<Data.Entity.ContractStatus, long>
    {
<<<<<<< Updated upstream
        Data.Entity.ContractStatus Save(Data.Entity.ContractStatus entity);
        List<Data.Entity.ContractStatus> Save(List<Data.Entity.ContractStatus> entity);

        Data.Entity.ContractStatus Update(Data.Entity.ContractStatus entity);
        List<Data.Entity.ContractStatus> Update(List<Data.Entity.ContractStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.ContractStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.ContractStatus> Find();
        Data.Entity.ContractStatus Find(long id);
=======
>>>>>>> Stashed changes
    }
}
