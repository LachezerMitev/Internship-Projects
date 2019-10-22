using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.AutoPartStatus
{
    class AutoPartStatusProcessor : IAutoPartStatusProcessor
    {
        IAutoPartStatusDao AutoPartStatusDao { get; set; }

        IAutoPartStatusParamConverter AutoPartStatusParamConverter { get; set; }
        IAutoPartStatusResultConverter AutoPartStatusResultConverter { get; set; }

        public AutoPartStatusResult Create(AutoPartStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<AutoPartStatusResult> Create(List<AutoPartStatusParam> param)
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

        public AutoPartStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AutoPartStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AutoPartStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AutoPartStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
