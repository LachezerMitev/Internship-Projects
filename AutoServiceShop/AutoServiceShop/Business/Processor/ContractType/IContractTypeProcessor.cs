using AutoServiceShop.Business.Processor.Converter.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.ContractType
{
    interface IContractTypeProcessor
    {
        ContractTypeResult Create(ContractTypeParam param);
        List<ContractTypeResult> Create(List<ContractTypeParam> param);

        void Update(long id, ContractTypeParam param);
        void Update(List<ContractTypeParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        ContractTypeResult Find(long id);
        List<ContractTypeResult> Find();
    }
}
