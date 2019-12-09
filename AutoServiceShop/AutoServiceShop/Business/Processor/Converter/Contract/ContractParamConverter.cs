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
        private IContractStatusDao _contractStatusDao;
        public IContractStatusDao ContractStatusDao
        {

            set { _contractStatusDao = value; }

            get
            {
                if (_contractStatusDao == null)
                {
                    _contractStatusDao = new ContractStatusDao();
                    return _contractStatusDao;
                }
                else
                {
                    return _contractStatusDao;
                }
            }
        }

        private IContractTypeDao _contractTypeDao;
        public IContractTypeDao ContractTypeDao
        {

            set { _contractTypeDao = value; }

            get
            {
                if (_contractTypeDao == null)
                {
                    _contractTypeDao = new ContractTypeDao();
                    return _contractTypeDao;
                }
                else
                {
                    return _contractTypeDao;
                }
            }
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
                entity = new Data.Entity.Contract
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

<<<<<<< Updated upstream
            entity.ContractStatus = ContractStatusDao.Find(param.ContractStatusId);
            entity.ContractType = ContractTypeDao.Find(param.ContractTypeId);
            entity.Salary = param.Salary;
            entity.WorkDayEnd = param.WorkDayEnd;
            entity.WorkDayStart = param.WorkDayStart;
=======
            ConverterStandart(param, entity);

            entity.ContractStatus = ContractStatusDao.Find(param.ContractStatusId);
            entity.ContractType = ContractTypeDao.Find(param.ContractTypeId);

            return entity;
        }

        public override Data.Entity.Contract ConvertSpecific(ContractParam param, Data.Entity.Contract entity)
        {
            entity.ContractStatus = _contractStatusDao.Find(param.ContractStatusId);
            entity.ContractType = _contractTypeDao.Find(param.ContractTypeId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
