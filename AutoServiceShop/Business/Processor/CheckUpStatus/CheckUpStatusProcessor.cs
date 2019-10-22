using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;

namespace AutoServiceShop.Business.Processor.CheckUpStatus
{
    class CheckUpStatusProcessor : ICheckUpStatusProcessor
    {
        ICheckUpStatusDao CheckUpStatusDao { get; set; }

        ICheckUpStatusParamConverter CheckUpStatusParamConverter { get; set; }
        ICheckUpStatusResultConverter CheckUpStatusResultConverter { get; set; }

        public CheckUpStatusResult Create(CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<CheckUpStatusResult> Create(List<CheckUpStatusParam> param)
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

        public CheckUpStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<CheckUpStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<CheckUpStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
