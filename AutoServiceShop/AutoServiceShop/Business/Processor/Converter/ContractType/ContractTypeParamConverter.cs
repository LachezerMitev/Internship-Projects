using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.ContractType;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    class ContractTypeParamConverter : BaseParamConverter<ContractTypeParam, Data.Entity.ContractType>, IContractTypeParamConverter
    {
<<<<<<< Updated upstream
        IContractTypeDao ContractTypeDao = new ContractTypeDao();
=======
        public override void ConvertSpecific(ContractTypeParam param, Data.Entity.ContractType entity) { }
>>>>>>> Stashed changes

        public override Data.Entity.ContractType GetResult(ContractTypeParam param)
        {
<<<<<<< Updated upstream
            Data.Entity.ContractType entity = null;
=======
            Data.Entity.ContractType entity = new Data.Entity.ContractType
            {
                Code = param.Code,
                Id = param.Id,
                Active = param.Active
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
