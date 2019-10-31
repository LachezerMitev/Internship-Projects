using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.AutoPartStatus
{
    interface IAutoPartStatusProcessor
    {
        AutoPartStatusResult Create(AutoPartStatusParam param);
        List<AutoPartStatusResult> Create(List<AutoPartStatusParam> param);

        void Update(long id, AutoPartStatusParam param);
        void Update(List<AutoPartStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        AutoPartStatusResult Find(long id);
        List<AutoPartStatusResult> Find();
    }
}
