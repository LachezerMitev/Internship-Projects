using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.CheckUpStatus
{
    interface ICheckUpStatusProcessor
    {
        CheckUpStatusResult Create(CheckUpStatusParam param);
        List<CheckUpStatusResult> Create(List<CheckUpStatusParam> param);

        void Update(long id, CheckUpStatusParam param);
        void Update(List<CheckUpStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        CheckUpStatusResult Find(long id);
        List<CheckUpStatusResult> Find();
    }
}
