using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;

namespace AutoServiceShop.Business.Processor.ContractType
{
    class ContractTypeProcessor : IContractTypeProcessor
    {
        ContractTypeDao ContractTypeDao { get; set; }

        ContractTypeParamConverter ContractTypeParamConverter { get; set; }
        ContractTypeResultConverter ContractTypeResultConverter { get; set; }

        public ContractTypeResult Create(ContractTypeParam param)
        {
            throw new NotImplementedException();
        }

        public List<ContractTypeResult> Create(List<ContractTypeParam> param)
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

        public ContractTypeResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ContractTypeResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ContractTypeParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ContractTypeParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
