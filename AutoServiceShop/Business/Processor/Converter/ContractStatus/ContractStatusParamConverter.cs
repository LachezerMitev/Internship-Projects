using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;

namespace AutoServiceShop.Business.Processor.Converter.ContractStatus
{
    class ContractStatusParamConverter : IContractStatusParamConverter
    {
        IContractStatusDao ContractStatusDao { get; set; }

        public Data.Entity.ContractStatus Convert(ContractStatusParam param)
        {
            Data.Entity.ContractStatus result = new Data.Entity.ContractStatus()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }

        public Data.Entity.ContractStatus Convert(ContractStatusParam param, Data.Entity.ContractStatus oldentity)
        {
            Data.Entity.ContractStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.ContractStatus();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            return entity;
        }
    }
}
