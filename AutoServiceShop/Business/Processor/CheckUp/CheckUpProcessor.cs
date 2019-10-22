using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;

namespace AutoServiceShop.Business.Processor.CheckUp
{
    class CheckUpProcessor : ICheckUpProcessor
    {
        ICheckUpDao CheckUpDao { get; set; }

        ICheckUpParamConverter CheckUpParamConverter { get; set; }
        ICheckUpResultConverter CheckUpResultConverter { get; set; }

        public CheckUpResult Create(CheckUpParam param)
        {
            throw new NotImplementedException();
        }

        public List<CheckUpResult> Create(List<CheckUpParam> param)
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

        public CheckUpResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<CheckUpResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, CheckUpParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<CheckUpParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
