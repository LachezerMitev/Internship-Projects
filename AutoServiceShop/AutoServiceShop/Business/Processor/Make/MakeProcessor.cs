using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Business.Processor.Converter.Make;

namespace AutoServiceShop.Business.Processor.Make
{
    class MakeProcessor : IMakeProcessor
    {
        MakeDao MakeDao { get; set; }

        MakeParamConverter MakeParamConverter { get; set; }
        MakeResultConverter MakeResultConverter { get; set; }

        public MakeResult Create(MakeParam param)
        {
            throw new NotImplementedException();
        }

        public List<MakeResult> Create(List<MakeParam> param)
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

        public MakeResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<MakeResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, MakeParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<MakeParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
