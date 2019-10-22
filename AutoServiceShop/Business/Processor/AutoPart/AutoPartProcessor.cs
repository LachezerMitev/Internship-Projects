using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;

namespace AutoServiceShop.Business.Processor.AutoPart
{
    class AutoPartProcessor : IAutoPartProcessor
    {
        IAutoPartDao AutoPartDao { get; set; }

        IAutoPartParamConverter AutoPartParamConverter { get; set; }
        IAutoPartResultConvert AutoPartResultConverter { get; set; }

        public AutoPartResult Create(AutoPartParam param)
        {
            throw new NotImplementedException();
        }

        public List<AutoPartResult> Create(List<AutoPartParam> param)
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

        public AutoPartResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AutoPartResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AutoPartParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AutoPartParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
