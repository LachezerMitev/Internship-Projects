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
        IContractTypeDao ContractTypeDao = new ContractTypeDao();

        public Data.Entity.ContractType Convert(ContractTypeParam param, Data.Entity.ContractType oldentity)
        {
            Data.Entity.ContractType entity = null;

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
                entity = new Data.Entity.ContractType
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.ContractType ConvertSpecific(ContractTypeParam param, Data.Entity.ContractType entity)
        {
            throw new NotImplementedException();
        }
    }
}
