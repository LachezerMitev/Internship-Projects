using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractType;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    class ContractParamConverter : BaseParamConverter<ContractParam, Data.Entity.Contract>, IContractParamconverter
    {
        IContractDao ContractDao = new ContractDao();
        IContractStatusDao ContractStatusDao = new ContractStatusDao();
        IContractTypeDao ContractTypeDao = new ContractTypeDao();

        public Data.Entity.Contract Convert(ContractParam param, Data.Entity.Contract oldentity)
        {
            Data.Entity.Contract entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                {
                    entity = oldentity;
                }
                else
                {
                    throw new Exception("You have changed either the ID or the description");
                }
            }
            else
            {
                entity = new Data.Entity.Contract
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            entity.ContractStatus = ContractStatusDao.Find(param.ContractStatusId);
            entity.ContractType = ContractTypeDao.Find(param.ContractTypeId);

            return entity;
        }

        public override Data.Entity.Contract ConvertSpecific(ContractParam param, Data.Entity.Contract entity)
        {
            entity.ContractStatus = ContractStatusDao.Find(param.ContractStatusId);
            entity.ContractType = ContractTypeDao.Find(param.ContractTypeId);

            return entity;
        }
    }
}
