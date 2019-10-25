using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    class ContractResultConverter : IContractResultConverter
    {
        public ContractResult Convert(Data.Entity.Contract param)
        {
            ContractResult result = new ContractResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                ContractStatus = param.ContractStatus,
                ContractType = param.ContractType,
                Salary = param.Salary,
                WorkDayEnd = param.WorkDayEnd,
                WorkDayStart = param.WorkDayStart
            };

            return result;
        }
    }
}
