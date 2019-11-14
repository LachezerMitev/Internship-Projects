using AutoServiceShop.Business.Processor.Converter.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Contract
{
    interface IContractProcessor
    {
        ContractResult Create(ContractParam param);
        List<ContractResult> Create(List<ContractParam> param);

        void Update(long id, ContractParam param);
        void Update(List<ContractParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        ContractResult Find(long id);
        List<ContractResult> Find();
    }
}
