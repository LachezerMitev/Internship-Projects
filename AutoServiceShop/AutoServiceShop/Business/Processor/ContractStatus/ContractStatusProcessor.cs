using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Business.Processor.Common;

namespace AutoServiceShop.Business.Processor.ContractStatus
{
    public class ContractStatusProcessor
        : BaseProcessor<IContractStatusParamConverter, IContractStatusResultConverter, ContractStatusParam, ContractStatusResult, IContractStatusDao, long, Data.Entity.ContractStatus>, IContractStatusProcessor
    {
<<<<<<< Updated upstream
        IContractStatusDao ContractStatusDao = new ContractStatusDao();

        IContractStatusParamConverter ContractStatusParamConverter = new ContractStatusParamConverter();
        IContractStatusResultConverter ContractStatusResultConverter = new ContractStatusResultConverter();

        public ContractStatusResult Create(ContractStatusParam param)
        {
            Data.Entity.ContractStatus entity = ContractStatusParamConverter.Convert(param, null);
            ContractStatusDao.Save(entity);

            return ContractStatusResultConverter.Convert(entity);
        }

        public List<ContractStatusResult> Create(List<ContractStatusParam> param)
        {
            List<Data.Entity.ContractStatus> entities = new List<Data.Entity.ContractStatus>();
            foreach (var item in param)
            {
                entities.Add(ContractStatusParamConverter.Convert(item, null));
            }
            ContractStatusDao.Save(entities);
            List<ContractStatusResult> result = new List<ContractStatusResult>();
            foreach (var item in entities)
            {
                result.Add(ContractStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            ContractStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.ContractStatus> entity = new List<Data.Entity.ContractStatus>();
            foreach (var id in idList)
            {
                entity.Add(ContractStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                ContractStatusDao.Delete(id);
            }
        }

        public ContractStatusResult Find(long id)
        {
            Data.Entity.ContractStatus entity = ContractStatusDao.Find(id);
            ContractStatusResult result = ContractStatusResultConverter.Convert(entity);
            return result;
        }

        public List<ContractStatusResult> Find()
        {
            List<Data.Entity.ContractStatus> entity = ContractStatusDao.Find();
            List<ContractStatusResult> results = new List<ContractStatusResult>();
            foreach (var item in entity)
            {
                results.Add(ContractStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ContractStatusParam param)
        {
            Data.Entity.ContractStatus oldEntity = ContractStatusDao.Find(id);
            Data.Entity.ContractStatus newEntity = ContractStatusParamConverter.Convert(param, null);
            ContractStatusDao.Update(newEntity);
        }

        public void Update(List<ContractStatusParam> param)
=======
        public ContractStatusProcessor(IContractStatusDao dao, IContractStatusParamConverter paramConverter, IContractStatusResultConverter resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
        }
    }
}
