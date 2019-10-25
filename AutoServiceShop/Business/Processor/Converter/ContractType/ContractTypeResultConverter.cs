using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    class ContractTypeResultConverter : IContractTypeResultConverter
    {
        public ContractTypeResult Convert(Data.Entity.ContractType param)
        {
            ContractTypeResult result = new ContractTypeResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
