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
<<<<<<< Updated upstream
        IContractTypeDao ContractTypeDao = new ContractTypeDao();
=======
        public override void ConvertSpecific(ContractTypeParam param, Data.Entity.ContractType entity) { }
>>>>>>> Stashed changes

        public Data.Entity.ContractType Convert(ContractTypeParam param, Data.Entity.ContractType oldentity)
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

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.ContractType
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
