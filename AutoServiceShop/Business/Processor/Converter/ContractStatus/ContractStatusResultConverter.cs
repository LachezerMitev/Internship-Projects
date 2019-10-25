using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.ContractStatus
{
    class ContractStatusResultConverter : IContractStatusResultConverter
    {
        public ContractStatusResult Convert(Data.Entity.ContractStatus param)
        {
            ContractStatusResult result = new ContractStatusResult()
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
