using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Contract;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    class ContractParamConverter : IContractParamconverter
    {
        IContractDao ContractDao { get; set; }

        public Data.Entity.Contract Convert(ContractParam param)
        {
            throw new NotImplementedException();
        }
    }
}
