using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.ContractType;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    class ContractTypeParamConverter : IContractTypeParamConverter
    {
        ContractTypeDao ContractTypeDao { get; set; }

        public Data.Entity.ContractType Convert(ContractTypeParam param)
        {
            throw new NotImplementedException();
        }
    }
}
