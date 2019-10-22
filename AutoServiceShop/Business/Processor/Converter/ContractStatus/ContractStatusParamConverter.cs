using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;

namespace AutoServiceShop.Business.Processor.Converter.ContractStatus
{
    class ContractStatusParamConverter : IContractStatusParamConverter
    {
        IContractStatusDao ContractStatusDao { get; set; }

        public Data.Entity.ContractStatus Convert(ContractStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
