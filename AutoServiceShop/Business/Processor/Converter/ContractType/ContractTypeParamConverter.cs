using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.ContractType;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    class ContractTypeParamConverter : IContractTypeParamConverter
    {
        IContractTypeDao ContractTypeDao { get; set; }

        public Data.Entity.ContractType Convert(ContractTypeParam param)
        {
            Data.Entity.ContractType result = new Data.Entity.ContractType()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }

        public Data.Entity.ContractType Convert(ContractTypeParam param, Data.Entity.ContractType oldentity)
        {
            Data.Entity.ContractType entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.ContractType();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            return entity;
        }
    }
}
