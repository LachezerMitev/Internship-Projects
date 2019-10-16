using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.ContractStatus
{
    interface IContractStatusProcessor
    {
        ContractStatusResult Create(ContractStatusParam param);
        List<ContractStatusResult> Create(List<ContractStatusParam> param);

        void Update(long id, ContractStatusParam param);
        void Update(List<ContractStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        ContractStatusResult Find(long id);
        List<ContractStatusResult> Find();
    }
}
