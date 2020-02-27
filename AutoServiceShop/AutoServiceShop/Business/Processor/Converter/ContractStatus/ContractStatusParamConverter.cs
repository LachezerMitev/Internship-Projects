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

        public Data.Entity.ContractStatus Convert(ContractStatusParam param, Data.Entity.ContractStatus oldentity)
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

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.ContractStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
            
            return entity;
        }
    }
}
