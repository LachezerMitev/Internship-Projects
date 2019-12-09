using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractType
{
    interface IContractTypeDao
    {
        Data.Entity.ContractType Save(Data.Entity.ContractType entity);
        List<Data.Entity.ContractType> Save(List<Data.Entity.ContractType> entity);

        Data.Entity.ContractType Update(Data.Entity.ContractType entity);
        List<Data.Entity.ContractType> Update(List<Data.Entity.ContractType> entity);

        void Delete(long id);
        void Delete(Data.Entity.ContractType entity);
        void Delete(List<long> idList);

        List<Data.Entity.ContractType> Find();
        Data.Entity.ContractType Find(long id);
        List<Data.Entity.ContractType> FindByField(string field, string value);
    }
}
