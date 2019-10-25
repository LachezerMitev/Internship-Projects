using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Contract;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    class ContractParamConverter : IContractParamconverter
    {
        IContractDao ContractDao { get; set; }

        public Data.Entity.Contract Convert(ContractParam param)
        {
            Data.Entity.Contract result = new Data.Entity.Contract()
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

        public Data.Entity.Contract Convert(ContractParam param, Data.Entity.Contract oldentity)
        {
            Data.Entity.Contract entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Contract();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            entity.ContractStatus = param.ContractStatus;
            entity.ContractType = param.ContractType;
            entity.Salary = param.Salary;
            entity.WorkDayEnd = param.WorkDayEnd;
            entity.WorkDayStart = param.WorkDayStart;

            return entity;
        }
    }
}
