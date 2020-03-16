using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    class ContractTypeResultConverter : BaseResultConverter<Data.Entity.ContractType, ContractTypeResult>, IContractTypeResultConverter
    {
        public override void ConvertSpecific(Data.Entity.ContractType param, ContractTypeResult result)
        {
<<<<<<< Updated upstream
            ContractTypeResult result = new ContractTypeResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
=======
>>>>>>> Stashed changes
        }
    }
}
