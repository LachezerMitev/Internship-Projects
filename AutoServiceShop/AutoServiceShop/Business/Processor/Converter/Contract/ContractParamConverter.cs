using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractType;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    class ContractParamConverter : IContractParamconverter
    {
        IContractDao ContractDao = new ContractDao();
        IContractStatusDao ContractStatusDao = new ContractStatusDao();
        IContractTypeDao ContractTypeDao = new ContractTypeDao();

        public Data.Entity.Contract Convert(ContractParam param, Data.Entity.Contract oldentity)
        {
            Data.Entity.Contract entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Contract
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.ContractStatus = ContractStatusDao.Find(param.ContractStatusId);
            entity.ContractType = ContractTypeDao.Find(param.ContractTypeId);
            entity.Salary = param.Salary;
            entity.WorkDayEnd = param.WorkDayEnd;
            entity.WorkDayStart = param.WorkDayStart;

            return entity;
        }
    }
}
