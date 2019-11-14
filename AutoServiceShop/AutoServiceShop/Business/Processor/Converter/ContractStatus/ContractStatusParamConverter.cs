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

        public Data.Entity.ContractStatus Convert(ContractStatusParam param, Data.Entity.ContractStatus oldentity)
        {
            Data.Entity.ContractStatus entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                {
                    entity = oldentity;
                }
                else
                {
                    throw new Exception("You have changed either the ID or the description");
                }
            }
            else
            {
                entity = new Data.Entity.ContractStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.ContractStatus ConvertSpecific(ContractStatusParam param, Data.Entity.ContractStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
