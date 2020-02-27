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
<<<<<<< Updated upstream
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
=======
        private readonly IContractStatusDao _contractStatusDao;

        private readonly IContractTypeDao _contractTypeDao;

        public ContractParamConverter(IContractStatusDao contractStatusDao, IContractTypeDao contractTypeDao)
        {
            _contractStatusDao = contractStatusDao;
            _contractTypeDao = contractTypeDao;
        }

        public override void ConvertSpecific(ContractParam param, Data.Entity.Contract entity)
        {
            entity.ContractStatus = _contractStatusDao.Find(param.ContractStatusId);
            entity.ContractType = _contractTypeDao.Find(param.ContractTypeId);
        }

        public override Data.Entity.Contract GetResult(ContractParam param)
        {
            Data.Entity.Contract entity = new Data.Entity.Contract
            {
                Code = param.Code,
                Id = param.Id,
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
