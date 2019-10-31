using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.CheckUp;

namespace AutoServiceShop.Business.Processor.CheckUp
{
    interface ICheckUpProcessor
    {
        CheckUpResult Create(CheckUpParam param);
        List<CheckUpResult> Create(List<CheckUpParam> param);

        void Update(long id, CheckUpParam param);
        void Update(List<CheckUpParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        CheckUpResult Find(long id);
        List<CheckUpResult> Find();
    }
}
