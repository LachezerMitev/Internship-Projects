using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Business.Processor.Converter.Contract;

namespace AutoServiceShop.Business.Processor.Contract
{
    class ContractProcessor : IContractProcessor
    {
        ContractDao ContractDao { get; set; }

        ContractParamConverter ContractParamConverter { get; set; }
        ContractResultConverter ContractResultConverter { get; set; }

        public ContractResult Create(ContractParam param)
        {
            throw new NotImplementedException();
        }

        public List<ContractResult> Create(List<ContractParam> param)
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

        public ContractResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ContractResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ContractParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ContractParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
