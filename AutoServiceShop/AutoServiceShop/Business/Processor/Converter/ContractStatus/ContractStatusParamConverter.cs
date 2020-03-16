using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;

namespace AutoServiceShop.Business.Processor.Converter.ContractStatus
{
    class ContractStatusParamConverter : BaseParamConverter<ContractStatusParam, Data.Entity.ContractStatus>, IContractStatusParamConverter
    {
        IContractStatusDao ContractStatusDao = new ContractStatusDao();

        public override void ConvertSpecific(ContractStatusParam param, Data.Entity.ContractStatus entity) { }

        public override Data.Entity.ContractStatus GetResult(ContractStatusParam param)
        {
<<<<<<< Updated upstream
            Data.Entity.ContractStatus entity = null;
=======
            Data.Entity.ContractStatus entity = new Data.Entity.ContractStatus
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
