using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractStatus
{
    interface IContractStatusDao
    {
        Data.Entity.ContractStatus Save(Data.Entity.ContractStatus entity);
        List<Data.Entity.ContractStatus> Save(List<Data.Entity.ContractStatus> entity);

        Data.Entity.ContractStatus Update(Data.Entity.ContractStatus entity);
        List<Data.Entity.ContractStatus> Update(List<Data.Entity.ContractStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.ContractStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.ContractStatus> Find();
        Data.Entity.ContractStatus Find(long id);
        List<Data.Entity.ContractStatus> FindByField(string field, string value);
    }
}
