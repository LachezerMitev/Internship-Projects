using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;

namespace AutoServiceShop.Business.Processor.ContractStatus
{
    class ContractStatusProcessor : IContractStatusProcessor
    {
        IContractStatusDao ContractStatusDao { get; set; }

        IContractStatusParamConverter ContractStatusParamConverter { get; set; }
        IContractStatusResultConverter ContractStatusResultConverter { get; set; }

        public ContractStatusResult Create(ContractStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<ContractStatusResult> Create(List<ContractStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ContractStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ContractStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ContractStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ContractStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
